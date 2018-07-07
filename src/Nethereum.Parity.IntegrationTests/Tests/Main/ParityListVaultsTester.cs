using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.Parity.RPC.Admin;
using Xunit;

namespace Loom.Nethereum.Parity.IntegrationTests.Tests.Main
{
    public class ParityListVaultsTester : RPCRequestTester<string[]>, IRPCRequestTester
    {
        public override async Task<string[]> ExecuteAsync(IClient client)
        {
            var parityListVaults = new ParityListVaults(client);
            return await parityListVaults.SendRequestAsync();
        }

        public override Type GetRequestType()
        {
            return typeof(ParityListVaults);
        }

        [Fact]
        public async void ShouldNotReturnNull()
        {
            var result = await ExecuteAsync();
            Assert.NotNull(result);
        }
    }
}