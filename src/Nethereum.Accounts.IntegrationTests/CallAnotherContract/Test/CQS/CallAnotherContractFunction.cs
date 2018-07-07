using System;
using System.Threading.Tasks;
using System.Numerics;
using Loom.Nethereum.Hex.HexTypes;
using Loom.Nethereum.Contracts.CQS;
using Loom.Nethereum.ABI.FunctionEncoding.Attributes;
using SolidityCallAnotherContract.Contracts.Test.DTOs;
namespace SolidityCallAnotherContract.Contracts.Test.CQS
{
    [Function("CallAnotherContract", "bytes")]
    public class CallAnotherContractFunction:ContractMessage
    {
        [Parameter("address", "theOther", 1)]
        public string TheOther {get; set;}
    }
}
