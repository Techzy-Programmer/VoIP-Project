using System;
using CSCore;
using System.IO;
using CSCore.DSP;
using System.Linq;
using CSCore.Codecs;
using CSCore.SoundIn;
using CSCore.Streams;
using System.Drawing;
using CSCore.SoundOut;
using CSCore.Codecs.WAV;
using BoltCall.Helper.FFT;
using System.Windows.Forms;
using BoltCall.Helper.Opus;
using System.ComponentModel;

namespace BoltCall.Interactives
{
    public partial class Test : Form
    {
        ISoundOut SOut;
        WasapiCapture SIn;
        IWaveSource WVSrc;
        LineSpectrum GFXRenderer;
        readonly Timer TmrRenderer;

        int FBC;
        WaveIn Rec;
        OpusEncoder OEnc;
        OpusDecoder ODec;
        WaveWriter WWriter;
        const int SRate = 24000;
        SoundInSource SInSource;
        bool IsRecording = false;
        long UnEncoded = 0, Encoded = 0;

        public Test()
        {
            InitializeComponent();
            TmrRenderer = new Timer { Interval = 50 };
            TmrRenderer.Tick += GfxRepeter_Tick;
        }

        protected override void OnClosing(CancelEventArgs E)
        {
            base.OnClosing(E);
            StopIfRunning();
        }

        private void GfxRepeter_Tick(object _, EventArgs E)
        {
            Image OldIMG = PBDisplay.Image;
            var RenderedIMG = GFXRenderer.CreateSpectrumLine(PBDisplay.Size, true);

            if (RenderedIMG != null)
            {
                PBDisplay.Image = RenderedIMG;
                if (OldIMG != null) OldIMG.Dispose();
            }
        }

        private void BtnAudio_Click(object _, EventArgs E)
        {
            var SelAudio = new OpenFileDialog()
            {
                Filter = CodecFactory.SupportedFilesFilterEn,
                Title = "Select an audio file...."
            };

            if (SelAudio.ShowDialog() == DialogResult.OK)
            {
                StopIfRunning();
                ISampleSource SMPLSrc = CodecFactory.Instance.GetCodec(SelAudio.FileName).ToSampleSource();
                    // .AppendSource(x => new PitchShifter(x), out _pitchShifter); // You can append any effect also

                SetupSampleSource(SMPLSrc);
                SOut = new WasapiOut();
                SOut.Initialize(WVSrc);
                SOut.Play();
                TmrRenderer.Start();
            }
        }

        private void BtnSystem_Click(object _, EventArgs E)
        {
            StopIfRunning();
            (SIn = new WasapiLoopbackCapture
                ()).Initialize();
            var SInSrc = new SoundInSource(SIn);
            SetupSampleSource(SInSrc.ToSampleSource());
            byte[] ABuff = new byte[WVSrc.WaveFormat.BytesPerSecond / 2];
            SInSrc.DataAvailable += (S, EV) => { while (WVSrc.Read(ABuff, 0, ABuff.Length) > 0) ; };

            SIn.Start();
            TmrRenderer.Start();
        }

        private void SetupSampleSource(ISampleSource ASampleSource)
        {
            const FftSize FftSz = FftSize.Fft4096;
            var SProvider = new BaseSpectrumProvider(ASampleSource
                .WaveFormat.Channels, ASampleSource.WaveFormat.SampleRate, FftSz);

            GFXRenderer = new LineSpectrum(FftSz)
            {
                SpectrumProvider = SProvider,
                UseAverage = true,
                BarCount = 10,
                BarSpacing = 5,
                IsXLogScale = true,
                ScalingStrategy = ScalingStrategy.Decibel
            };

            var NotificationSource = new SingleBlockNotificationStream(ASampleSource);
            NotificationSource.SingleBlockRead += (s, a) => SProvider.Add(a.Left, a.Right);
            WVSrc = NotificationSource.ToWaveSource(16);
        }

        private void BtnMicrophone_Click(object _, EventArgs E)
        {
            MessageBox.Show(this, "Click on start recording to see the output graph from microphone.",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnRecToggle_Click(object _, EventArgs E)
        {
            IsRecording = !IsRecording;
            BtnRecToggle.Text = IsRecording ?
                "Save Recording" : "Start Recording";

            try
            {
                if (IsRecording)
                {
                    StopIfRunning();
                    var ANm = TBFileName.Text;
                    ODec = OpusDecoder.Create(SRate);
                    OEnc = OpusEncoder.Create(SRate, App.Voip);
                    FBC = OEnc.FrameByteCount(SRate / 1000 * 20);
                    OEnc.DiscontinousTransmission = true;
                    OEnc.Bitrate = 20000;

                    if (ANm.Length == 0) TBFileName.Text = ANm = "Test-Audio.wav";
                    if (!ANm.EndsWith(".wav")) ANm += ".wav";
                    if (File.Exists(ANm)) File.Delete(ANm);

                    (Rec = new WaveIn(new WaveFormat(SRate, 16, 1))
                    {
                        Latency = 100,
                        Device = WaveInDevice.DefaultDevice
                    }).Initialize();

                    SInSource = new SoundInSource(Rec) { FillWithZeros = false };
                    WWriter = new WaveWriter(ANm, SInSource.WaveFormat);
                    SInSource.DataAvailable += SInSource_DataAvailable;

                    var SInSrc = new SoundInSource(Rec);
                    SetupSampleSource(SInSrc.ToSampleSource());
                    byte[] ABuff = new byte[WVSrc.WaveFormat.BytesPerSecond / 2];
                    SInSrc.DataAvailable += (S, EV) => { while (WVSrc.Read(ABuff, 0, ABuff.Length) > 0) ; };
                    TmrRenderer.Start();
                    Rec.Start();
                }
                else
                {
                    Rec?.Stop();
                    Rec?.Dispose();
                    StopIfRunning();
                    OEnc?.Dispose();
                    ODec?.Dispose();
                    WWriter?.Dispose();
                    SInSource?.Dispose();
                    SInSource.DataAvailable
                        -= SInSource_DataAvailable;
                }
            }
            catch { IsRecording = !IsRecording; }
            BtnRecToggle.Text = IsRecording ?
                "Save Recording" : "Start Recording";
        }

        private void SInSource_DataAvailable(object _, DataAvailableEventArgs E)
        {
            int ReadBytes;
            if (SInSource == null || OEnc == null ||
                ODec == null || WWriter == null) return;
            byte[] BaseBuff = new byte[SInSource.WaveFormat.BytesPerSecond / 2];

            while ((ReadBytes = SInSource.Read(BaseBuff, 0, BaseBuff.Length)) > 0)
            {
                var BuffTrimmed = BaseBuff.Take(ReadBytes).ToArray();
                int SegCount = ReadBytes / FBC;

                for (int I = 0; I < SegCount; I++)
                {
                    byte[] EachSeg = new byte[FBC];
                    for (int J = 0; J < EachSeg.Length; J++)
                        EachSeg[J] = BuffTrimmed[(I * FBC) + J];
                    var EncodedBuff = OEnc.Encode(EachSeg); // Send this encoded buffer to network
                    Encoded += EncodedBuff.Length;

                    var Decoded = ODec.Decode(EncodedBuff); // Decode back to original sound on other side of network
                    WWriter.Write(Decoded, 0, Decoded.Length);
                    UnEncoded += Decoded.Length;
                }
            }
        }

        private void StopIfRunning()
        {
            TmrRenderer.Stop();

            if (SOut != null)
            {
                SOut.Stop();
                SOut.Dispose();
                SOut = null;
            }
            if (SIn != null)
            {
                SIn.Stop();
                SIn.Dispose();
                SIn = null;
            }
            if (WVSrc != null)
            {
                WVSrc.Dispose();
                WVSrc = null;
            }
        }
    }
}
