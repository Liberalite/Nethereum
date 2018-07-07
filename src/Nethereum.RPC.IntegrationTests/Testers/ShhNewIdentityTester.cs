using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Shh;

namespace Loom.Nethereum.RPC.Tests.Testers
{
    public class ShhNewIdentityTester : IRPCRequestTester
    {
        public async Task<object> ExecuteTestAsync(IClient client)
        {
            var shhNewIdentity = new ShhNewIdentity(client);
            return await shhNewIdentity.SendRequestAsync();
        }

        public Type GetRequestType()
        {
            return typeof (ShhNewIdentity);
        }
    }
}