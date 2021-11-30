using System;
using System.Linq;

namespace BoltCall.Helper.Opus
{
    public class OpusEncoder : IDisposable
    {
        private bool IsDisposed;
        private IntPtr _Encoder;

        public int MaxDataBytes { get; set; }
        public int InputChannels { get; private set; }
        public int InputSamplingRate { get; private set; }
        public App Application { get; private set; }

        public static OpusEncoder Create(int InputSamplingRate, App AppType)
        {
            if (InputSamplingRate != 12000 && InputSamplingRate != 16000 && InputSamplingRate != 24000
                && InputSamplingRate != 48000) throw new ArgumentOutOfRangeException("Input Sampling-Rate");
            IntPtr encoder = OpusAPI.opus_encoder_create(InputSamplingRate, 1, (int)AppType, out IntPtr OErr);
            if ((Errors)OErr != Errors.OK) throw new Exception("Error creating encoder!");
            return new OpusEncoder(encoder, InputSamplingRate, 1, AppType);
        }

        private OpusEncoder(IntPtr Enc, int InSamplingRate, int InChannels, App AppType)
        {
            _Encoder = Enc;
            InputSamplingRate = InSamplingRate;
            InputChannels = InChannels;
            Application = AppType;
            MaxDataBytes = 4000;
        }

        public unsafe byte[] Encode(byte[] InputPCMSample)
        {
            if (IsDisposed) throw new ObjectDisposedException("OpusEncoder");

            int Len = 0; IntPtr EncPTR;
            byte[] Encoded = new byte[MaxDataBytes];
            int Frames = FrameCount(InputPCMSample);

            fixed (byte * BEnc = Encoded)
            {
                EncPTR = new IntPtr(BEnc);
                Len = OpusAPI.opus_encode(_Encoder,
                    InputPCMSample,Frames, EncPTR, InputPCMSample.Length);
            }

            if (Len < 0) throw new Exception
                    ("Encoding failed - " + ((Errors)Len).ToString());
            return Encoded.Take(Len).ToArray();
        }

        public int FrameCount(byte[] PCMSample)
            => PCMSample.Length / (2 * InputChannels);

        public int FrameByteCount(int FrameCount)
            => FrameCount * 2 * InputChannels;

        public int Bitrate
        {
            get
            {
                if (IsDisposed) throw new ObjectDisposedException("OpusEncoder");
                var RetVal = OpusAPI.opus_encoder_ctl(_Encoder, Ctl.GetBitrateRequest, out int BitRate);
                if (RetVal < 0) throw new Exception("Encoder error - " + ((Errors)RetVal).ToString());
                return BitRate;
            }
            set
            {
                if (IsDisposed) throw new ObjectDisposedException("OpusEncoder");
                var RetVal = OpusAPI.opus_encoder_ctl(_Encoder, Ctl.SetBitrateRequest, value);
                if (RetVal < 0) throw new Exception("Encoder error - " + ((Errors)RetVal).ToString());
            }
        }

        public int Complexity
        {
            get
            {
                if (IsDisposed) throw new ObjectDisposedException("OpusEncoder");
                var RetVal = OpusAPI.opus_encoder_ctl(_Encoder, Ctl.GetComplexity, out int BitRate);
                if (RetVal < 0) throw new Exception("Encoder error - " + ((Errors)RetVal).ToString());
                return BitRate;
            }
            set
            {
                if (IsDisposed) throw new ObjectDisposedException("OpusEncoder");
                if (value < 0 || value > 10) throw new ArgumentOutOfRangeException
                        ("Complexity value should be in the range of 0 to 10 (+ve)");
                var RetVal = OpusAPI.opus_encoder_ctl(_Encoder, Ctl.SetComplexity, value);
                if (RetVal < 0) throw new Exception("Encoder error - " + ((Errors)RetVal).ToString());
            }
        }

        public bool ForwardErrorCorrection
        {
            get
            {
                if (_Encoder == IntPtr.Zero) throw new ObjectDisposedException("OpusEncoder");
                int RetVal = OpusAPI.opus_encoder_ctl(_Encoder, Ctl.GetInbandFECRequest, out int Fec);
                if (RetVal < 0) throw new Exception("Encoder error - " + ((Errors)RetVal).ToString());
                return Fec > 0;
            }
            set
            {
                if (_Encoder == IntPtr.Zero) throw new ObjectDisposedException("OpusEncoder");
                var RetVal = OpusAPI.opus_encoder_ctl(_Encoder, Ctl.SetInbandFECRequest, value ? 1 : 0);
                if (RetVal < 0) throw new Exception("Encoder error - " + ((Errors)RetVal).ToString());
            }
        }

        public bool DiscontinousTransmission
        {
            get
            {
                if (_Encoder == IntPtr.Zero) throw new ObjectDisposedException("OpusEncoder");
                int RetVal = OpusAPI.opus_encoder_ctl(_Encoder, Ctl.GetDTX, out int Fec);
                if (RetVal < 0) throw new Exception("Encoder error - " + ((Errors)RetVal).ToString());
                return Fec > 0;
            }
            set
            {
                if (_Encoder == IntPtr.Zero) throw new ObjectDisposedException("OpusEncoder");
                var RetVal = OpusAPI.opus_encoder_ctl(_Encoder, Ctl.SetDTX, value ? 1 : 0);
                if (RetVal < 0) throw new Exception("Encoder error - " + ((Errors)RetVal).ToString());
            }
        }

        ~OpusEncoder() => Dispose();

        public void Dispose()
        {
            if (IsDisposed) return;
            GC.SuppressFinalize(this);

            if (_Encoder != IntPtr.Zero)
            {
                OpusAPI.opus_encoder_destroy(_Encoder);
                _Encoder = IntPtr.Zero;
            }

            IsDisposed = true;
        }
    }
}