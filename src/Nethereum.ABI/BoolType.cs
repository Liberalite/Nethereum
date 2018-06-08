using Loom.Nethereum.ABI.Decoders;
using Loom.Nethereum.ABI.Encoders;

namespace Loom.Nethereum.ABI
{
    public class BoolType : ABIType
    {
        public BoolType() : base("bool")
        {
            Decoder = new BoolTypeDecoder();
            Encoder = new BoolTypeEncoder();
        }
    }
}