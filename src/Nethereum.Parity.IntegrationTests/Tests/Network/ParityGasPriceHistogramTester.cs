using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.Parity.RPC.Network;
using Xunit;

namespace Loom.Nethereum.Parity.IntegrationTests.Tests.Network
{
    public class ParityGasPriceHistogramTester : RPCRequestTester<string>, IRPCRequestTester
    {
        public override async Task<string> ExecuteAsync(IClient client)
        {
            var parityGasPriceHistogram = new ParityGasPriceHistogram(client);
            return await parityGasPriceHistogram.SendRequestAsync();
        }

        public override Type GetRequestType()
        {
            return typeof(ParityGasPriceHistogram);
        }

        [Fact]
        public async void ShouldNotReturnNull()
        {
            var result = await ExecuteAsync();
            Assert.NotNull(result);
        }
    }
}