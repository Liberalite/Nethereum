using System;
using System.Threading.Tasks;
using System.Numerics;
using Loom.Nethereum.Hex.HexTypes;
using Loom.Nethereum.ABI.FunctionEncoding.Attributes;
namespace SolidityCallAnotherContract.Contracts.TheOther.DTOs
{
    [FunctionOutput]
    public class CallMeOutputDTO
    {
        [Parameter("bytes", "test", 1)]
        public byte[] Test {get; set;}
    }
}
