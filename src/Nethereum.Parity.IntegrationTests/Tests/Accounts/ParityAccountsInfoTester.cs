using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.Parity.RPC.Accounts;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Loom.Nethereum.Parity.IntegrationTests.Tests.Accounts
{
    public class ParityAccountsInfoTester : RPCRequestTester<JObject>, IRPCRequestTester
    {
        public override async Task<JObject> ExecuteAsync(IClient client)
        {
            var parityAccountsInfo = new ParityAccountsInfo(client);
            return await parityAccountsInfo.SendRequestAsync();
        }

        public override Type GetRequestType()
        {
            return typeof(ParityAccountsInfo);
        }

        [Fact]
        public async void ShouldGetInfo()
        {
            var result = await ExecuteAsync();
            Assert.NotNull(result);
        }
    }
}