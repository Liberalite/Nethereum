using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Net;

namespace Loom.Nethereum.RPC.Tests.Testers
{
    public class NetListeningTester : IRPCRequestTester
    {
        public async Task<object> ExecuteTestAsync(IClient client)
        {
            var netListening = new NetListening(client);
            return await netListening.SendRequestAsync();
        }

        public Type GetRequestType()
        {
            return typeof (NetListening);
        }
    }
}