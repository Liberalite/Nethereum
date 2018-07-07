using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Eth.DTOs;
using Loom.Nethereum.RPC.Eth.Transactions;
using Xunit;

namespace Loom.Nethereum.RPC.Tests.Testers
{
    public class EthGetTransactionByHashTester : RPCRequestTester<Transaction>
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
            var ethGetTransactionByHash = new EthGetTransactionByHash(client);
            return await ethGetTransactionByHash.SendRequestAsync(Settings.GetTransactionHash());
        }

        public override Type GetRequestType()
        {
            return typeof(EthGetTransactionByHash);
        }
    }
}