using System;
using System.Threading.Tasks;
using Loom.Nethereum.Hex.HexTypes;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Eth.DTOs;
using Loom.Nethereum.RPC.Eth.Transactions;
using Xunit;

namespace Loom.Nethereum.RPC.Tests.Testers
{
    public class EthGetTransactionByBlockHashAndIndexTester : RPCRequestTester<Transaction>
    {
        [Fact]
        public async void ShouldReturnTheTransaction()
        {
            var result = await ExecuteAsync();
            Assert.NotNull(result);
            Assert.Equal(Settings.GetTransactionHash(), result.TransactionHash);

        }

        public override async Task<Transaction> ExecuteAsync(IClient client)
        {
            var ethGetTransactionByBlockHashAndIndex = new EthGetTransactionByBlockHashAndIndex(client);
            return await ethGetTransactionByBlockHashAndIndex.SendRequestAsync(Settings.GetBlockHash(), new HexBigInteger(0));
        }

        public override Type GetRequestType()
        {
            return typeof(EthGetTransactionByBlockHashAndIndex);
        }
    }
}