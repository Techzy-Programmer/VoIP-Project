using System;
using System.Runtime.InteropServices;

namespace BoltCall.Helper.Opus
{
    internal class OpusAPI
    {
        #pragma warning disable IDE1006
        
        [DllImport("Opus.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr opus_encoder_create(int Fs, int channels, int application, out IntPtr error);

        [DllImport("Opus.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void opus_encoder_destroy(IntPtr encoder);

        [DllImport("Opus.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int opus_encode(IntPtr st, byte[] pcm, int frame_size, IntPtr data, int max_data_bytes);

        [DllImport("Opus.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr opus_decoder_create(int Fs, int channels, out IntPtr error);

        [DllImport("Opus.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void opus_decoder_destroy(IntPtr decoder);

        [DllImport("Opus.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int opus_decode(IntPtr st, byte[] data, int len, IntPtr pcm, int frame_size, int decode_fec);

        [DllImport("Opus.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int opus_encoder_ctl(IntPtr st, Ctl request, int value);

        [DllImport("Opus.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int opus_encoder_ctl(IntPtr st, Ctl request, out int value);
        
        #pragma warning restore IDE1006
    }

    public enum Ctl : int
    {
        SetDTX = 4016,
        GetDTX = 4017,
        SetComplexity = 4010,
        GetComplexity = 4011,
        SetBitrateRequest = 4002,
        GetBitrateRequest = 4003,
        SetInbandFECRequest = 4012,
        GetInbandFECRequest = 4013
    }

    public enum App
    {
        Voip = 2048,
        Audio = 2049,
        Restricted_LowLatency = 2051
    }

    public enum Errors
    {
        OK = 0,
        BadArg = -1,
        AllocFail = -7,
        InvalidState = -6,
        BufferToSmall = -2,
        InternalError = -3,
        InvalidPacket = -4,
        Unimplemented = -5
    }
}