using System;
using System.Linq;

namespace BoltCall.Helper.Opus
{
    public class OpusDecoder : IDisposable
    {
        private bool IsDisposed;
        private IntPtr _Decoder;

        public int MaxDataBytes { get; set; }
        public int OutputChannels { get; private set; }
        public bool ForwardErrorCorrection { get; set; }
        public int OutputSamplingRate { get; private set; }

        public static OpusDecoder Create(int OutputSampleRate)
        {
            if (OutputSampleRate != 12000 && OutputSampleRate != 16000 && OutputSampleRate != 24000
                && OutputSampleRate != 48000) throw new ArgumentOutOfRangeException("Ouput Sampling-Rate");
            IntPtr ODecoder = OpusAPI.opus_decoder_create(OutputSampleRate, 1, out IntPtr OErr);
            if ((Errors)OErr != Errors.OK) throw new Exception("Error creating decoder!");
            return new OpusDecoder(ODecoder, OutputSampleRate, 1);
        }

        private OpusDecoder(IntPtr Dec, int OutSamplingRate, int OutChannels)
        {
            _Decoder = Dec;
            OutputSamplingRate = OutSamplingRate;
            OutputChannels = OutChannels;
            MaxDataBytes = 4000;
        }

        public unsafe byte[] Decode(byte[] InputOpusData)
        {
            if (IsDisposed) throw new ObjectDisposedException("OpusDecoder");

            int Len = 0; IntPtr DecPTR;
            byte[] Decoded = new byte[MaxDataBytes];
            int FrameCount = this.FrameCount(MaxDataBytes);

            fixed (byte * BDec = Decoded)
            {
                DecPTR = new IntPtr(BDec);
                if (InputOpusData != null) Len = OpusAPI.opus_decode(_Decoder, InputOpusData, InputOpusData.Length, DecPTR, FrameCount, 0);
                else Len = OpusAPI.opus_decode(_Decoder, null, 0, DecPTR, FrameCount, ForwardErrorCorrection ? 1 : 0);
            }

            if (Len < 0) throw new Exception
                    ("Decoding failed - " + ((Errors)Len).ToString());
            return Decoded.Take(Len * 2).ToArray();
        }

        public int FrameCount(int BuffSize)
            => BuffSize / (2 * OutputChannels);

        ~OpusDecoder() => Dispose();

        public void Dispose()
        {
            if (IsDisposed) return;
            GC.SuppressFinalize(this);

            if (_Decoder != IntPtr.Zero)
            {
                OpusAPI.opus_decoder_destroy(_Decoder);
                _Decoder = IntPtr.Zero;
            }

            IsDisposed = true;
        }
    }
}