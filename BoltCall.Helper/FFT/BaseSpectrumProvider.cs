using System;
using CSCore.DSP;
using System.Collections.Generic;

namespace BoltCall.Helper.FFT
{
    public class BaseSpectrumProvider : FftProvider, ISpectrumProvider
    {
        private readonly int _SampleRate;
        private readonly List<object> _Contexts = new List<object>();

        public BaseSpectrumProvider(int Channels, int SampleRate, FftSize FFTSize) : base(Channels, FFTSize)
        {
            if (SampleRate <= 0)
                throw new ArgumentOutOfRangeException("SampleRate");
            _SampleRate = SampleRate;
        }

        public int GetFftBandIndex(float Frequency)
        {
            int Size = (int)base.FftSize;
            double F = _SampleRate / 2.0;
            return (int)(Frequency / F * (Size / 2));
        }

        public bool GetFftData(float[] FftResBuffer, object Context)
        {
            if (_Contexts.Contains(Context))
                return false;
            _Contexts.Add(Context);
            GetFftData(FftResBuffer);
            return true;
        }

        public override void Add(float[] Samples, int Count)
        {
            base.Add(Samples, Count);
            if (Count > 0) _Contexts.Clear();
        }

        public override void Add(float Left, float Right)
        {
            base.Add(Left, Right);
            _Contexts.Clear();
        }
    }
}