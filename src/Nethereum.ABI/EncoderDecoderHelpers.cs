using System.Linq;
using Loom.Nethereum.ABI.Decoders;

namespace Loom.Nethereum.ABI
{
    public class EncoderDecoderHelpers
    {
        public static int GetNumberOfBytes(byte[] encoded)
        {
            var intDecoder = new IntTypeDecoder();
            var numberOfBytesEncoded = encoded.Take(32);
            return intDecoder.DecodeInt(numberOfBytesEncoded.ToArray());
        }
    }
}