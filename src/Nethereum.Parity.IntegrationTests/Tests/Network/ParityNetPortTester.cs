using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.Parity.RPC.Network;
using Xunit;

namespace Loom.Nethereum.Parity.IntegrationTests.Tests.Network
{
    public class ParityNetPortTester : RPCRequestTester<int>, IRPCRequestTester
    {
        public override async Task<int> ExecuteAsync(IClient client)
        {
            var parityNetPort = new ParityNetPort(client);
            return await parityNetPort.SendRequestAsync();
        }

        public override Type GetRequestType()
        {
            return typeof(ParityNetPort);
        }

        [Fact]
        public async void ShouldNotReturnNull()
        {
            var result = await ExecuteAsync();
            Assert.True(result > 0);
        }
    }
}