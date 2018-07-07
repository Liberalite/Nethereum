using Loom.Nethereum.ABI.FunctionEncoding.Attributes;
using Loom.Nethereum.Contracts.CQS;

namespace Nethereum.StandardTokenEIP20.CQS
{
    [Function("symbol", "string")]
    public class SymbolFunction:ContractMessage
    {

    }
}
