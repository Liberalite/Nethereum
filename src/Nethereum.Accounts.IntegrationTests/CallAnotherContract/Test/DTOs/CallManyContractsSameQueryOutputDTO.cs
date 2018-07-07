using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Numerics;
using Loom.Nethereum.Hex.HexTypes;
using Loom.Nethereum.ABI.FunctionEncoding.Attributes;
namespace SolidityCallAnotherContract.Contracts.Test.DTOs
{
    [FunctionOutput]
    public class CallManyContractsSameQueryOutputDTO
    {
        [Parameter("bytes[]", "result", 1)]
        public List<byte[]> Result {get; set;}
    }
}
