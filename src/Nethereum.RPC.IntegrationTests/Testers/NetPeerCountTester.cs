using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Net;

namespace Loom.Nethereum.RPC.Tests.Testers
{
    public class NetPeerCountTester : IRPCRequestTester
    {
        public async Task<object> ExecuteTestAsync(IClient client)
        {
            var netPeerCount = new NetPeerCount(client);
            return await netPeerCount.SendRequestAsync();
        }

        public Type GetRequestType()
        {
            return typeof (NetPeerCount);
        }
    }
}