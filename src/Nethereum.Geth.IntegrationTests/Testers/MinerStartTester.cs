using System;
using System.Threading.Tasks;
using Loom.Nethereum.Geth.RPC.Miner;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Tests.Testers;
using Xunit;

namespace Loom.Nethereum.Geth.Tests.Testers
{
    public class MinerStartTester : RPCRequestTester<bool>, IRPCRequestTester
    {
        public override async Task<bool> ExecuteAsync(IClient client)
        {
            var minerStart = new MinerStart(client);
            return await minerStart.SendRequestAsync();
        }

        public override Type GetRequestType()
        {
            return typeof(MinerStart);
        }

        [Fact]
        public async void ShouldStartMiner()
        {
            var result = await ExecuteAsync();
            Assert.True(result);
        }
    }
}