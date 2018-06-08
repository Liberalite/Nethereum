using System;
using System.Threading.Tasks;
using Loom.Nethereum.Hex.HexTypes;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Eth.Blocks;
using Loom.Nethereum.RPC.Eth.DTOs;
using Xunit;

namespace Loom.Nethereum.RPC.Tests.Testers
{

    public class EthGetBlockTransactionCountByHashTester : RPCRequestTester<HexBigInteger>, IRPCRequestTester
    {
        [Fact]
        public async void ShouldReturnTransactionCount()
        {
            var result = await ExecuteAsync();
            Assert.NotNull(result);
            //we have configured one transaction at least for this block
            Assert.True(result.Value > 0);
        }

        public override async Task<HexBigInteger> ExecuteAsync(IClient client)
        {
            var ethGetBlockTransactionCountByHash = new EthGetBlockTransactionCountByHash(client);
            return
                await
                    ethGetBlockTransactionCountByHash.SendRequestAsync(Settings.GetBlockHash());
        }

        public override Type GetRequestType()
        {
            return typeof (EthGetBlockTransactionCountByHash);
        }
    }
}