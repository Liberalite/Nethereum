using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Net;

namespace Loom.Nethereum.RPC.Tests.Testers
{
    public class NetVersionTester : IRPCRequestTester
    {
        public async Task<object> ExecuteTestAsync(IClient client)
        {
            var netVersion = new NetVersion(client);
            return await netVersion.SendRequestAsync();
        }

        public Type GetRequestType()
        {
            return typeof (NetVersion);
        }
    }
}