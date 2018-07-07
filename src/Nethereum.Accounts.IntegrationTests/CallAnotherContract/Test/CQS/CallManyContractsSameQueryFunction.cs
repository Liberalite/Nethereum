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
    [Function("callManyContractsSameQuery", "bytes[]")]
    public class CallManyContractsSameQueryFunctionBase:ContractMessage
    {
        [Parameter("address[]", "destination", 1)]
        public virtual List<BigInteger> Destination {get; set;}
        [Parameter("bytes", "data", 2)]
        public virtual byte[] Data {get; set;}
    }

    public partial class CallManyContractsSameQueryFunction : CallManyContractsSameQueryFunctionBase
    {
        
    }

    public partial class CallManyContractsSameQueryFunction : CallManyContractsSameQueryFunctionBase
    {
        [Parameter("address[]", "destination", 1)]
        public new List<string> Destination { get; set; }
    }

}
