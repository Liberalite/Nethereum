using Loom.Nethereum.ABI.FunctionEncoding.Attributes;

namespace Loom.Nethereum.StandardTokenEIP20.DTOs
{
    [FunctionOutput]
    public class NameOutputDTO
    {
        [Parameter("string", "", 1)]
        public string B {get; set;}
    }
}
