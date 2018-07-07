using System.Numerics;
using Loom.Nethereum.ABI.FunctionEncoding.Attributes;

namespace Loom.Nethereum.StandardTokenEIP20.DTOs
{
    [FunctionOutput]
    public class AllowanceOutputDTO
    {
        [Parameter("uint256", "remaining", 1)]
        public BigInteger Remaining {get; set;}
    }
}
