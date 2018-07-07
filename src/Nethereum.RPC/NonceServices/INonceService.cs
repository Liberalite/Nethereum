using System.Threading.Tasks;
using Loom.Nethereum.Hex.HexTypes;
using Loom.Nethereum.JsonRpc.Client;

namespace Nethereum.RPC.NonceServices
{
    public interface INonceService
    {
        IClient Client { get; set; }
        Task<HexBigInteger> GetNextNonceAsync();
    }
}