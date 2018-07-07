using System;
using System.Threading.Tasks;
using System.Numerics;
using Loom.Nethereum.Hex.HexTypes;
using Loom.Nethereum.Contracts.CQS;
using Loom.Nethereum.ABI.FunctionEncoding.Attributes;
using SolidityCallAnotherContract.Contracts.TheOther.DTOs;
namespace SolidityCallAnotherContract.Contracts.TheOther.CQS
{
    [Function("CallMe", "bytes")]
    public class CallMeFunction:FunctionMessage
    {
        [Parameter("string", "name", 1)]
        public string Name {get; set;}
        [Parameter("string", "greeting", 2)]
        public string Greeting {get; set;}
    }
}
