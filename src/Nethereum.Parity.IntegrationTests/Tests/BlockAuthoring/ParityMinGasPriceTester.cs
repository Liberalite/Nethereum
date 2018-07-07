using System;
using System.Threading.Tasks;
using Loom.Nethereum.Hex.HexTypes;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.Parity.RPC.BlockAuthoring;
using Xunit;

namespace Loom.Nethereum.Parity.IntegrationTests.Tests.BlockAuthoring
{
    public class ParityMinGasPriceTester : RPCRequestTester<HexBigInteger>, IRPCRequestTester
    {
        public override async Task<HexBigInteger> ExecuteAsync(IClient client)
        {
            var parityMinGasPrice = new ParityMinGasPrice(client);
            return await parityMinGasPrice.SendRequestAsync();
        }

        public override Type GetRequestType()
        {
            return typeof(ParityMinGasPrice);
        }

        [Fact]
        public async void ShouldNotReturnNull()
        {
            var result = await ExecuteAsync();
            Assert.NotNull(result);
        }
    }
}