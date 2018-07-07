using System;
using System.Threading.Tasks;
using Loom.Nethereum.Geth.RPC.Admin;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Tests.Testers;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Loom.Nethereum.Geth.Tests.Testers
{
    public class AdminPeersTester : RPCRequestTester<JArray>, IRPCRequestTester
    {
        public override async Task<JArray> ExecuteAsync(IClient client)
        {
            var adminPeers = new AdminPeers(client);
            return await adminPeers.SendRequestAsync();
        }

        public override Type GetRequestType()
        {
            return typeof(AdminPeers);
        }

        [Fact]
        public async void ShouldReturnEmptyArray()
        {
            var result = await ExecuteAsync();
            Assert.True(result.Count == 0);
        }
    }
}