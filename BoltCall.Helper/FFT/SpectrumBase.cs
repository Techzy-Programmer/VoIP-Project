using System;
using CSCore;
using CSCore.DSP;
using System.Diagnostics;
using System.ComponentModel;
using System.Collections.Generic;

namespace BoltCall.Helper.FFT
{
    public class SpectrumBase
    {
        protected const double MaxDbValue = 0;
        protected const int ScaleFactorSqr = 2;
        protected const double MinDbValue = -90;
        private const int ScaleFactorLinear = 9;
        protected const double DbScale = (MaxDbValue - MinDbValue);

        private int _FftSize;
        private bool _IsXLogScale;
        private int _MaxFftIndex;
        private bool _UseAverage;
        private int _MaxFrequencyIndex;
        private int _MinFrequency = 20;
        private int _MinFrequencyIndex;
        private int[] _SpectrumIndexMax;
        protected int SpectrumResolution;
        private int _MaxFrequency = 20000;
        private int[] _SpectrumLogScaleIndexMax;
        private ScalingStrategy _ScalingStrategy;
        private ISpectrumProvider _SpectrumProvider;


        public int MaximumFrequency
        {
            get { return _MaxFrequency; }
            set
            {
                if (value <= MinimumFrequency)
                    throw new ArgumentOutOfRangeException("value",
                        "Value must not be less or equal the MinimumFrequency.");
                _MaxFrequency = value;
                UpdateFrequencyMapping();
            }
        }

        public int MinimumFrequency
        {
            get { return _MinFrequency; }
            set
            {
                if (value < 0) throw new
                        ArgumentOutOfRangeException("MinimumFrequency");
                _MinFrequency = value;
                UpdateFrequencyMapping();
            }
        }

        public ISpectrumProvider SpectrumProvider
        {
            get { return _SpectrumProvider; }
            set { _SpectrumProvider = value ?? throw new ArgumentNullException("SpectrumProvider"); }
        }

        public bool IsXLogScale
        {
            get { return _IsXLogScale; }
            set
            {
                _IsXLogScale = value;
                UpdateFrequencyMapping();
            }
        }

        public ScalingStrategy ScalingStrategy
        {
            get { return _ScalingStrategy; }
            set { _ScalingStrategy = value; }
        }

        public bool UseAverage
        {
            get { return _UseAverage; }
            set { _UseAverage = value; }
        }

        public FftSize FftSize
        {
            get { return (FftSize)_FftSize; }
            protected set
            {
                if ((int)Math.Log((int)value, 2) % 1 != 0) throw
                        new ArgumentOutOfRangeException("FftSize");
                _FftSize = (int)value;
                _MaxFftIndex = _FftSize / 2 - 1;
            }
        }

        protected virtual void UpdateFrequencyMapping()
        {
            _MaxFrequencyIndex = Math.Min(_SpectrumProvider.GetFftBandIndex(MaximumFrequency) + 1, _MaxFftIndex);
            _MinFrequencyIndex = Math.Min(_SpectrumProvider.GetFftBandIndex(MinimumFrequency), _MaxFftIndex);

            int ActualResolution = SpectrumResolution;
            int IndexCount = _MaxFrequencyIndex - _MinFrequencyIndex;
            double LinearIndexBucketSize = Math.Round(IndexCount / (double)ActualResolution, 3);

            _SpectrumIndexMax = _SpectrumIndexMax.CheckBuffer(ActualResolution, true);
            _SpectrumLogScaleIndexMax = _SpectrumLogScaleIndexMax.CheckBuffer(ActualResolution, true);
            double MaxLog = Math.Log(ActualResolution, ActualResolution);

            for (int I = 1; I < ActualResolution; I++)
            {
                int LogIndex = (int)((MaxLog - Math.Log((ActualResolution + 1) - I,
                    (ActualResolution + 1))) * IndexCount) + _MinFrequencyIndex;
                _SpectrumIndexMax[I - 1] = _MinFrequencyIndex + (int)(I * LinearIndexBucketSize);
                _SpectrumLogScaleIndexMax[I - 1] = LogIndex;
            }

            if (ActualResolution > 0)
            {
                _SpectrumIndexMax[_SpectrumIndexMax.Length - 1] =
                    _SpectrumLogScaleIndexMax[_SpectrumLogScaleIndexMax.Length - 1] = _MaxFrequencyIndex;
            }
        }

        protected virtual SpectrumPointData[] CalculateSpectrumPoints(double MaxValue, float[] FftBuff)
        {
            double LastValue = 0;
            int SpectrumPointIndex = 0;
            double Value0 = 0, Value = 0;
            double ActualMaxValue = MaxValue;
            var DataPoints = new List<SpectrumPointData>();

            for (int I = _MinFrequencyIndex; I <= _MaxFrequencyIndex; I++)
            {
                switch (ScalingStrategy)
                {
                    case ScalingStrategy.Linear: Value0 = (FftBuff[I] * ScaleFactorLinear) * ActualMaxValue; break;
                    case ScalingStrategy.Sqrt: Value0 = ((Math.Sqrt(FftBuff[I])) * ScaleFactorSqr) * ActualMaxValue; break;
                    case ScalingStrategy.Decibel: Value0 = (((20 * Math.Log10(FftBuff[I])) - MinDbValue) / DbScale) * ActualMaxValue; break;
                }

                bool Recalc = true;
                Value = Math.Max(0, Math.Max(Value0, Value));

                while (SpectrumPointIndex <= _SpectrumIndexMax.Length - 1 && I == (IsXLogScale ?
                    _SpectrumLogScaleIndexMax[SpectrumPointIndex] : _SpectrumIndexMax[SpectrumPointIndex]))
                {
                    if (!Recalc) Value = LastValue;
                    if (Value > MaxValue) Value = MaxValue;
                    if (_UseAverage && SpectrumPointIndex > 0) Value = (LastValue + Value) / 2.0;
                    DataPoints.Add(new SpectrumPointData { SpectrumPointIndex = SpectrumPointIndex, Value = Value });

                    LastValue = Value;
                    Value = 0.0;
                    SpectrumPointIndex++;
                    Recalc = false;
                }
            }

            return DataPoints.ToArray();
        }



        [DebuggerDisplay("{Value}")]
        protected struct SpectrumPointData
        {
            public int SpectrumPointIndex;
            public double Value;
        }
    }

    public enum ScalingStrategy
    {
        Decibel,
        Linear,
        Sqrt
    }
}