using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.Quorum.RPC.DTOs;
using Loom.Nethereum.RPC.Infrastructure;

namespace Nethereum.Quorum.RPC
{
    public class QuorumNodeInfo : GenericRpcRequestResponseHandlerNoParam<NodeInfo>
    {
        public QuorumNodeInfo(IClient client) : base(client, ApiMethods.quorum_nodeInfo.ToString())
        {
        }
    }
}