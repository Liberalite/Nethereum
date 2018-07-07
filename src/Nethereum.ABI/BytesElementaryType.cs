using Loom.Nethereum.ABI.Decoders;
using Loom.Nethereum.ABI.Encoders;

namespace Nethereum.ABI
{
    public class BytesElementaryType : ABIType
    {
        public BytesElementaryType(string name, int size) : base(name)
        {
            Decoder = new BytesElementaryTypeDecoder(size);
            Encoder = new BytesElementaryTypeEncoder(size);
        }
    }
}