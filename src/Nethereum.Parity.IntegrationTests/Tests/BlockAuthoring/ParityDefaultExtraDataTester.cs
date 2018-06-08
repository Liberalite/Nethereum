using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.Parity.RPC.BlockAuthoring;
using Xunit;

namespace Loom.Nethereum.Parity.IntegrationTests.Tests.BlockAuthoring
{
    public class ParityDefaultExtraDataTester : RPCRequestTester<string>, IRPCRequestTester
    {
        public override async Task<string> ExecuteAsync(IClient client)
        {
            var parityDefaultExtraData = new ParityDefaultExtraData(client);
            return await parityDefaultExtraData.SendRequestAsync();
        }

        public override Type GetRequestType()
        {
            return typeof(ParityDefaultExtraData);
        }

        [Fact]
        public async void ShouldGetDefaultExtraData()
        {
            var result = await ExecuteAsync();
            Assert.NotNull(result);
        }
    }
}