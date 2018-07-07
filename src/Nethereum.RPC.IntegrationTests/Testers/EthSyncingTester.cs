using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Eth;
using Loom.Nethereum.RPC.Eth.DTOs;
using Xunit;

namespace Loom.Nethereum.RPC.Tests.Testers
{
    
    public class EthSyncingTester : RPCRequestTester<SyncingOutput>, IRPCRequestTester
    {
        [Fact]
        public async void HighestBlockShouldBeBiggerThan0WhenSyncing()
        {
            var syncResult = await ExecuteAsync();
            if (syncResult.IsSyncing)
            {
                Assert.True(syncResult.HighestBlock.Value > 0);
            }
        }

        public override async Task<SyncingOutput> ExecuteAsync(IClient client)
        {
            var ethSyncing = new EthSyncing(client);
            return await ethSyncing.SendRequestAsync();
        }

        public override Type GetRequestType()
        {
            return typeof (EthSyncing);
        }
    }
}