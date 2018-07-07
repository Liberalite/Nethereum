using System.Numerics;
using Loom.Nethereum.ABI.FunctionEncoding.Attributes;

namespace Loom.Nethereum.StandardTokenEIP20.DTOs
{
    [FunctionOutput]
    public class AllowedOutputDTO
    {
        [Parameter("uint256", "", 1)]
        public BigInteger B {get; set;}
    }
}