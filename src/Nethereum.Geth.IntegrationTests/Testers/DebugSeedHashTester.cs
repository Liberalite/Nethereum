using System;
using System.Threading.Tasks;
using Loom.Nethereum.Geth.RPC.Debug;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Tests.Testers;
using Xunit;

namespace Loom.Nethereum.Geth.Tests.Testers
{
    public class DebugSeedHashTester : RPCRequestTester<string>, IRPCRequestTester
    {
        public override async Task<string> ExecuteAsync(IClient client)
        {
            var debugSeedHash = new DebugSeedHash(client);
            return await debugSeedHash.SendRequestAsync(Settings.GetBlockNumber());
        }

        public override Type GetRequestType()
        {
            return typeof(DebugSeedHash);
        }

        [Fact]
        public async void ShouldReturnTheHash()
        {
            var result = await ExecuteAsync();
            Assert.NotNull(result);
        }
    }
}