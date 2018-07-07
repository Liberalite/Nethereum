using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.Parity.RPC.Admin;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Loom.Nethereum.Parity.IntegrationTests.Tests.Main
{
    public class ParityLocalTransactionsTester : RPCRequestTester<JObject>, IRPCRequestTester
    {
        public override async Task<JObject> ExecuteAsync(IClient client)
        {
            var parityLocalTransactions = new ParityLocalTransactions(client);
            return await parityLocalTransactions.SendRequestAsync();
        }

        public override Type GetRequestType()
        {
            return typeof(ParityLocalTransactions);
        }

        [Fact]
        public async void ShouldNotReturnNull()
        {
            var result = await ExecuteAsync();
            Assert.NotNull(result);
        }
    }
}