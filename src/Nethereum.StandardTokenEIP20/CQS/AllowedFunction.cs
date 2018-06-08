using Loom.Nethereum.ABI.FunctionEncoding.Attributes;
using Loom.Nethereum.Contracts.CQS;

namespace Loom.Nethereum.StandardTokenEIP20.CQS
{
    [Function("allowed", "uint256")]
    public class AllowedFunction:ContractMessage
    {
        [Parameter("address", "", 1)]
        public string B {get; set;}
        [Parameter("address", "", 2)]
        public string C {get; set;}
    }
}
