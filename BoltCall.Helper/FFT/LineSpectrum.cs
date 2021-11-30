using System;
using CSCore.DSP;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Drawing2D;

namespace BoltCall.Helper.FFT
{
    public class LineSpectrum : SpectrumBase
    {
        private int _BarCount;
        private double _BarSpacing;
        private double _BarWidth;
        private Size _CurrentSize;

        public LineSpectrum(FftSize fftSize)
        {
            FftSize = fftSize;
        }

        public double BarWidth
        {
            get { return _BarWidth; }
        }

        public double BarSpacing
        {
            get { return _BarSpacing; }
            set
            {
                if (value < 0) throw new
                        ArgumentOutOfRangeException("BarSpacing");
                _BarSpacing = value;
                UpdateFrequencyMapping();
            }
        }

        public int BarCount
        {
            get { return _BarCount; }
            set
            {
                if (value <= 0) throw new
                        ArgumentOutOfRangeException("BarCount");
                _BarCount = value;
                SpectrumResolution = value;
                UpdateFrequencyMapping();
            }
        }

        public Size CurrentSize
        {
            get { return _CurrentSize; }
            protected set
            {
                _CurrentSize = value;
            }
        }

        private Bitmap CreateSpectrumLine(Size SZ, Brush LBrush, Color BackColor, bool IsHighQuality)
        {
            if (!UpdateFrequencyMappingIfNessesary(SZ)) return null;
            var FftBuff = new float[(int)FftSize];

            if (SpectrumProvider.GetFftData(FftBuff, this))
            {
                using (var DrawPen = new Pen(LBrush, (float)_BarWidth))
                {
                    var BitMap = new Bitmap(SZ.Width, SZ.Height);

                    using (Graphics _Graphics = Graphics.FromImage(BitMap))
                    {
                        PrepareGraphics(_Graphics, IsHighQuality); _Graphics.Clear(BackColor);
                        CreateSpectrumLineInternal(_Graphics, DrawPen, FftBuff, SZ);
                    }

                    return BitMap;
                }
            }

            return null;
        }

        public Bitmap CreateSpectrumLine(Size SZ, bool IsHighQuality)
        {
            if (!UpdateFrequencyMappingIfNessesary(SZ)) return null;

            using (LinearGradientBrush LGBrush = new LinearGradientBrush(new RectangleF(0, 0, (float)_BarWidth, SZ.Height),
                Color.YellowGreen, Color.OrangeRed, LinearGradientMode.Vertical))
            {
                ColorBlend CBlend = new ColorBlend(3)
                {
                    Colors = new Color[3] { Color.OrangeRed, Color.Pink, Color.YellowGreen },
                    Positions = new float[3] { 0f, 0.6f, 1f }
                };

                LGBrush.InterpolationColors = CBlend;
                return CreateSpectrumLine(SZ, LGBrush, Color.Transparent, IsHighQuality);
            }
        }

        private void CreateSpectrumLineInternal(Graphics _Graphics, Pen DPen, float[] FftBuff, Size SZ)
        {
            SpectrumPointData[] SpecPoints = CalculateSpectrumPoints(SZ.Height, FftBuff);

            for (int I = 0; I < SpecPoints.Length; I++)
            {
                SpectrumPointData SPDat = SpecPoints[I];
                int BarIndex = SPDat.SpectrumPointIndex;
                double XCoord = BarSpacing * (BarIndex + 1)
                    + (_BarWidth * BarIndex) + _BarWidth / 2;
                var Point1 = new PointF((float)XCoord, SZ.Height);
                var Point2 = new PointF((float)XCoord, SZ.Height - (float)SPDat.Value - 1);
                _Graphics.DrawLine(DPen, Point1, Point2);
            }
        }

        protected override void UpdateFrequencyMapping()
        {
            _BarWidth = Math.Max(((_CurrentSize.Width - (BarSpacing
                * (BarCount + 1))) / BarCount), 0.00001);
            base.UpdateFrequencyMapping();
        }

        private bool UpdateFrequencyMappingIfNessesary(Size NewSize)
        {
            if (NewSize != CurrentSize)
            {
                CurrentSize = NewSize;
                UpdateFrequencyMapping();
            }

            return NewSize.Width > 0 && NewSize.Height > 0;
        }

        private void PrepareGraphics(Graphics Gfx, bool IsHighQuality)
        {
            if (IsHighQuality)
            {
                Gfx.SmoothingMode = SmoothingMode.AntiAlias;
                Gfx.CompositingQuality = CompositingQuality.AssumeLinear;
                Gfx.PixelOffsetMode = PixelOffsetMode.Default;
                Gfx.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            }
            else
            {
                Gfx.SmoothingMode = SmoothingMode.HighSpeed;
                Gfx.CompositingQuality = CompositingQuality.HighSpeed;
                Gfx.PixelOffsetMode = PixelOffsetMode.None;
                Gfx.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;
            }
        }
    }
}