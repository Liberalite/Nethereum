using System;
using System.Threading.Tasks;
using Loom.Nethereum.Geth.RPC.Miner;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Tests.Testers;
using Xunit;

namespace Loom.Nethereum.Geth.Tests.Testers
{
    public class MinerStopTester : RPCRequestTester<bool>, IRPCRequestTester
    {
        public override async Task<bool> ExecuteAsync(IClient client)
        {
            var minerStop = new MinerStop(client);
            return await minerStop.SendRequestAsync();
        }

        public override Type GetRequestType()
        {
            return typeof(MinerStop);
        }

        [Fact]
        public async void ShouldStopMiner()
        {
            var result = await ExecuteAsync();
            Assert.True(result);
        }
    }
}