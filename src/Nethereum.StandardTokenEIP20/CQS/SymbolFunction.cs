using Loom.Nethereum.ABI.FunctionEncoding.Attributes;
using Loom.Nethereum.Contracts.CQS;

namespace Loom.Nethereum.StandardTokenEIP20.CQS
{
    [Function("symbol", "string")]
    public class SymbolFunction:ContractMessage
    {

    }
}
