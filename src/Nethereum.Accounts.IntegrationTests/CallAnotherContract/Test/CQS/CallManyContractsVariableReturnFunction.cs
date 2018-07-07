using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Numerics;
using Loom.Nethereum.Hex.HexTypes;
using Loom.Nethereum.Contracts.CQS;
using Loom.Nethereum.ABI.FunctionEncoding.Attributes;
using SolidityCallAnotherContract.Contracts.Test.DTOs;
namespace SolidityCallAnotherContract.Contracts.Test.CQS
{
    [Function("callManyContractsVariableReturn", "bytes[]")]
    public class CallManyContractsVariableReturnFunction:ContractMessage
    {
        [Parameter("address[]", "destination", 1)]
        public List<string> Destination {get; set;}
        [Parameter("bytes[]", "data", 2)]
        public List<byte[]> Data {get; set;}
    }
}
