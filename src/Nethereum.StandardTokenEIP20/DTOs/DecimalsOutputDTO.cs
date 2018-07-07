using Loom.Nethereum.ABI.FunctionEncoding.Attributes;

namespace Loom.Nethereum.StandardTokenEIP20.DTOs
{
    [FunctionOutput]
    public class DecimalsOutputDTO
    {
        [Parameter("uint8", "", 1)]
        public byte B {get; set;}
    }
}
