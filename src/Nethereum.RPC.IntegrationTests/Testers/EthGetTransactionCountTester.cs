using System;
using System.Threading.Tasks;
using Loom.Nethereum.Hex.HexTypes;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Eth.Transactions;
using Xunit;

namespace Loom.Nethereum.RPC.Tests.Testers
{
    public class EthGetTransactionCountTester : RPCRequestTester<HexBigInteger>
    {
        [Fact]
        public async void ShouldReturnTheTransactionCountOfTheAccount()
        {
            var result = await ExecuteAsync();
            Assert.NotNull(result);
            Assert.True(result.Value > 0);
        }

        public override async Task<HexBigInteger> ExecuteAsync(IClient client)
        {
            var ethGetTransactionCount = new EthGetTransactionCount(client);
            return await ethGetTransactionCount.SendRequestAsync(Settings.GetDefaultAccount());
        }

        public override Type GetRequestType()
        {
            return typeof(EthGetTransactionCount);
        }
    }
}