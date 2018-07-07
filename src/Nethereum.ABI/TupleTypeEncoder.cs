using System;
using Loom.Nethereum.ABI.Encoders;
using Loom.Nethereum.ABI.FunctionEncoding;
using Loom.Nethereum.ABI.Model;

namespace Nethereum.ABI
{
    public class TupleTypeEncoder : ITypeEncoder
    {
        private readonly ParametersEncoder parametersEncoder;

        public TupleTypeEncoder()
        {
            parametersEncoder = new ParametersEncoder();
        }

        public Parameter[] Components { get; set; }

        public byte[] Encode(object value)
        {
            if (!(value == null || value is object[]))
                throw new Exception("Expected object array of component values to encode");
            var input = value as object[];
            return parametersEncoder.EncodeParameters(Components, input);
        }
    }
}