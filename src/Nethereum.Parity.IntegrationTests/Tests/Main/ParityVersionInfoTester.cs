using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.Parity.RPC.Admin;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Loom.Nethereum.Parity.IntegrationTests.Tests.Main
{
    public class ParityVersionInfoTester : RPCRequestTester<JObject>, IRPCRequestTester
    {
        public override async Task<JObject> ExecuteAsync(IClient client)
        {
            var parityVersionInfo = new ParityVersionInfo(client);
            return await parityVersionInfo.SendRequestAsync();
        }

        public override Type GetRequestType()
        {
            return typeof(ParityVersionInfo);
        }

        [Fact]
        public async void ShouldNotReturnNull()
        {
            var result = await ExecuteAsync();
            Assert.NotNull(result);
        }
    }
}