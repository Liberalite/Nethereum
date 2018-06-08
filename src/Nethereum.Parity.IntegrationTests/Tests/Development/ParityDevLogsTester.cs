using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.Parity.RPC.Development;
using Xunit;

namespace Loom.Nethereum.Parity.IntegrationTests.Tests.Development
{
    public class ParityDevLogsTester : RPCRequestTester<string[]>, IRPCRequestTester
    {
        public override async Task<string[]> ExecuteAsync(IClient client)
        {
            var parityDevLogs = new ParityDevLogs(client);
            return await parityDevLogs.SendRequestAsync();
        }

        public override Type GetRequestType()
        {
            return typeof(ParityDevLogs);
        }

        [Fact]
        public async void ShouldNotReturnNull()
        {
            var result = await ExecuteAsync();
            Assert.NotNull(result);
        }
    }
}