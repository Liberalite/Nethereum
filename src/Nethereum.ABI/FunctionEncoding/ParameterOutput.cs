using System;
using Loom.Nethereum.ABI.Model;

namespace Loom.Nethereum.ABI.FunctionEncoding
{
    public class ParameterOutput
    {
        public Parameter Parameter { get; set; }
        public int DataIndexStart { get; set; }
        public object Result { get; set; }
        
    }
}