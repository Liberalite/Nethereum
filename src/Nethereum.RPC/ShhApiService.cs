using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Shh;

namespace Loom.Nethereum.RPC
{
    public class ShhApiService : RpcClientWrapper
    {
        public ShhApiService(IClient client) : base(client)
        {
            NewIdentity = new ShhNewIdentity(client);
            Version = new ShhVersion(client);
        }

        public ShhNewIdentity NewIdentity { get; private set; }
        public ShhVersion Version { get; private set; }
    }
}