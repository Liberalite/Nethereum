using System;
using System.Threading.Tasks;
using Loom.Nethereum.Geth.RPC.Debug;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Tests.Testers;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Loom.Nethereum.Geth.Tests.Testers
{
    public class DebugGcStatsTester : RPCRequestTester<JObject>, IRPCRequestTester
    {
        public override async Task<JObject> ExecuteAsync(IClient client)
        {
            var debugGcStats = new DebugGcStats(client);
            return await debugGcStats.SendRequestAsync();
        }

        public override Type GetRequestType()
        {
            return typeof(DebugGcStats);
        }

        [Fact]
        public async void ShouldReturnTheGcStatsAsJObject()
        {
            var result = await ExecuteAsync();
            Assert.NotNull(result);
        }
    }
}