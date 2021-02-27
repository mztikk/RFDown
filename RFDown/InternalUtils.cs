using RFDown.RandomR;

namespace RFDown
{
    internal static class InternalUtils
    {
        internal static readonly CryptoRandom s_rng = new CryptoRandom();
        internal const int StreamBufferSize = 8192;
    }
}
