using System.Linq;
using System.Text;
using Loom.Nethereum.ABI.Model;

namespace Loom.Nethereum.ABI.FunctionEncoding
{
    public class SerpentSignatureEncoder : SignatureEncoder
    {
        public override string GenerateSignature(string name, Parameter[] parameters)
        {
            var signature = new StringBuilder();
            signature.Append(name);
            signature.Append(" ");
            var paramSignature = parameters.OrderBy(x => x.Order).Select(x => x.SerpentSignature).ToArray();
            signature.Append(string.Join("", paramSignature));
            return signature.ToString();
        }
    }
}