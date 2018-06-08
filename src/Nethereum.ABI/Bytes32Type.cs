using Loom.Nethereum.ABI.Decoders;
using Loom.Nethereum.ABI.Encoders;

namespace Loom.Nethereum.ABI
{
    public class Bytes32Type : ABIType
    {
        public Bytes32Type(string name) : base(name)
        {
            Decoder = new Bytes32TypeDecoder();
            Encoder = new Bytes32TypeEncoder();
        }
    }
}