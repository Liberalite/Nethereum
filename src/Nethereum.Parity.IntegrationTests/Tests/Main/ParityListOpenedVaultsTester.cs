using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.Parity.RPC.Admin;
using Xunit;

namespace Loom.Nethereum.Parity.IntegrationTests.Tests.Main
{
    public class ParityListOpenedVaultsTester : RPCRequestTester<string[]>, IRPCRequestTester
    {
        public override async Task<string[]> ExecuteAsync(IClient client)
        {
            var parityListOpenedVaults = new ParityListOpenedVaults(client);
            return await parityListOpenedVaults.SendRequestAsync();
        }

        public override Type GetRequestType()
        {
            return typeof(ParityListOpenedVaults);
        }

        [Fact]
        public async void ShouldNotReturnNull()
        {
            var result = await ExecuteAsync();
            Assert.NotNull(result);
        }
    }
}