using Loom.Nethereum.ABI.FunctionEncoding.Attributes;
using Loom.Nethereum.Contracts.CQS;

namespace Loom.Nethereum.StandardTokenEIP20.CQS
{
    [Function("balanceOf", "uint256")]
    public class BalanceOfFunction:ContractMessage
    {
        [Parameter("address", "_owner", 1)]
        public string Owner {get; set;}
    }
}
