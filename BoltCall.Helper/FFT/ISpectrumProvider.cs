namespace BoltCall.Helper.FFT
{
    public interface ISpectrumProvider
    {
        int GetFftBandIndex(float Freq);
        bool GetFftData(float[] FftBuff, object Context);
    }
}