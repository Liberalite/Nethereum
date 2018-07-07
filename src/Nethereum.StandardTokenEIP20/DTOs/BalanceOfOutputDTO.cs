using System.Numerics;
using Loom.Nethereum.ABI.FunctionEncoding.Attributes;

namespace Loom.Nethereum.StandardTokenEIP20.DTOs
{
    [FunctionOutput]
    public class BalanceOfOutputDTO
    {
        [Parameter("uint256", "balance", 1)]
        public BigInteger Balance {get; set;}
    }
}
