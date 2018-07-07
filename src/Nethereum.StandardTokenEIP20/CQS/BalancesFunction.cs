using Loom.Nethereum.ABI.FunctionEncoding.Attributes;
using Loom.Nethereum.Contracts.CQS;

namespace Loom.Nethereum.StandardTokenEIP20.CQS
{
    [Function("balances", "uint256")]
    public class BalancesFunction:ContractMessage
    {
        [Parameter("address", "", 1)]
        public string B {get; set;}
    }
}
