using Loom.Nethereum.ABI.FunctionEncoding.Attributes;
using Loom.Nethereum.Contracts.CQS;

namespace Nethereum.StandardTokenEIP20.CQS
{
    [Function("totalSupply", "uint256")]
    public class TotalSupplyFunction:ContractMessage
    {

    }
}
