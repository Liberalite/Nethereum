using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Shh;

namespace Loom.Nethereum.RPC.Tests.Testers
{
    public class ShhVersionTester : IRPCRequestTester
    {
        public async Task<object> ExecuteTestAsync(IClient client)
        {
            var shhVersion = new ShhVersion(client);
            return await shhVersion.SendRequestAsync();
        }

        public Type GetRequestType()
        {
            return typeof (ShhVersion);
        }
    }
}