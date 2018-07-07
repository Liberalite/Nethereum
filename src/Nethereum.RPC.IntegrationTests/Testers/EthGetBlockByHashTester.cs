using System;
using System.Linq;
using System.Threading.Tasks;
using Loom.Nethereum.Hex.HexTypes;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Eth;
using Loom.Nethereum.RPC.Eth.Blocks;
using Loom.Nethereum.RPC.Eth.DTOs;
using Xunit;

namespace Loom.Nethereum.RPC.Tests.Testers
{
    public class EthGetBlockByHashTester : RPCRequestTester<BlockWithTransactions>, IRPCRequestTester
    {
        [Fact]
        public async void ShouldReturnBlockWithHashes()
        {
            var result = await ExecuteAsync();
            Assert.NotNull(result);
            Assert.NotNull(result.Transactions.FirstOrDefault(x => x.TransactionHash == Settings.GetTransactionHash()));
        }

        public override async Task<BlockWithTransactions> ExecuteAsync(IClient client)
        {
            var ethGetBlockByHash = new EthGetBlockWithTransactionsByHash(client);
            return
                await
                    ethGetBlockByHash.SendRequestAsync(Settings.GetBlockHash());
        }

        public override Type GetRequestType()
        {
            return typeof(EthGetBlockWithTransactionsByHash);
        }
    }
}