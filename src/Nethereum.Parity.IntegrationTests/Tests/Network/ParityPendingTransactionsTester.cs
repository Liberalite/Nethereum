using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.Parity.RPC.Network;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Loom.Nethereum.Parity.IntegrationTests.Tests.Network
{
    public class ParityPendingTransactionsTester : RPCRequestTester<JArray>, IRPCRequestTester
    {
        public override async Task<JArray> ExecuteAsync(IClient client)
        {
            var parityPendingTransactions = new ParityPendingTransactions(client);
            return await parityPendingTransactions.SendRequestAsync();
        }

        public override Type GetRequestType()
        {
            return typeof(ParityPendingTransactions);
        }

        [Fact]
        public async void ShouldNotReturnNull()
        {
            var result = await ExecuteAsync();
            Assert.NotNull(result);
        }
    }
}