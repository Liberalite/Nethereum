using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.Parity.RPC.Accounts;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Loom.Nethereum.Parity.IntegrationTests.Tests.Accounts
{
    public class ParityHardwareAccountsInfoTester : RPCRequestTester<JObject>, IRPCRequestTester
    {
        public override async Task<JObject> ExecuteAsync(IClient client)
        {
            var parityHardwareAccountsInfo = new ParityHardwareAccountsInfo(client);
            return await parityHardwareAccountsInfo.SendRequestAsync();
        }

        public override Type GetRequestType()
        {
            return typeof(ParityHardwareAccountsInfo);
        }

        [Fact]
        public async void ShouldGetHardwareAccountsInfo()
        {
            var result = await ExecuteAsync();
            Assert.NotNull(result);
        }
    }
}