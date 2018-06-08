using System;
using System.Threading.Tasks;
using Loom.Nethereum.Geth.RPC.Debug;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Tests.Testers;
using Xunit;

namespace Loom.Nethereum.Geth.Tests.Testers
{
    public class DebugGetBlockRlpTester : RPCRequestTester<string>, IRPCRequestTester
    {
        public override async Task<string> ExecuteAsync(IClient client)
        {
            var debugGetBlockRlp = new DebugGetBlockRlp(client);
            return await debugGetBlockRlp.SendRequestAsync(Settings.GetBlockNumber());
        }

        public override Type GetRequestType()
        {
            return typeof(DebugGetBlockRlp);
        }

        [Fact]
        public async void ShouldReturnTheBlockRplAsAString()
        {
            var result = await ExecuteAsync();
            Assert.NotNull(result);
        }
    }
}