using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Net;

namespace Loom.Nethereum.RPC
{
    public class NetApiService : RpcClientWrapper
    {
        public NetApiService(IClient client) : base(client)
        {
            Listening = new NetListening(client);
            PeerCount = new NetPeerCount(client);
            Version = new NetVersion(client);
        }

        public NetListening Listening { get; private set; }
        public NetPeerCount PeerCount { get; private set; }
        public NetVersion Version { get; private set; }
    }
}