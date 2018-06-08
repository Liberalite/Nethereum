using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Infrastructure;

namespace Loom.Nethereum.Quorum.RPC
{
    public class QuorumMakeBlock : GenericRpcRequestResponseHandlerNoParam<string>
    {
        public QuorumMakeBlock(IClient client) : base(client, ApiMethods.quorum_makeBlock.ToString())
        {
        }
    }
}