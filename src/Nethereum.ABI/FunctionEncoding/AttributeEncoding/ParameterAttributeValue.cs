using System.Reflection;
using Loom.Nethereum.ABI.FunctionEncoding.Attributes;

namespace Loom.Nethereum.ABI.FunctionEncoding.AttributeEncoding
{
    public class ParameterAttributeValue
    {
        public ParameterAttribute ParameterAttribute { get; set; }
        public object Value { get; set; }
        public PropertyInfo PropertyInfo { get; set; }
    }
}