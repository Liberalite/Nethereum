using System;
using System.Threading.Tasks;
using System.Numerics;
using Loom.Nethereum.Hex.HexTypes;
using Loom.Nethereum.ABI.FunctionEncoding.Attributes;
namespace SolidityCallAnotherContract.Contracts.Test.DTOs
{
    [FunctionOutput]
    public class CallAnotherContractOutputDTO
    {
        [Parameter("bytes", "result", 1)]
        public byte[] Result {get; set;}
    }
}
