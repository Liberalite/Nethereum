using System;
using System.Threading.Tasks;
using Loom.Nethereum.Hex.HexTypes;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Eth;
using Xunit;

namespace Loom.Nethereum.RPC.Tests.Testers
{

    public class EthGasPriceTester : RPCRequestTester<HexBigInteger>, IRPCRequestTester
    {
        [Fact]
        public async void ShouldGetTheGasPrice()
        {
            var result = await ExecuteAsync();
            Assert.True(result.Value > 0);
        }

        public override async Task<HexBigInteger> ExecuteAsync(IClient client)
        {
            var ethGasPrice = new EthGasPrice(client);
            return await ethGasPrice.SendRequestAsync();
        }

        public override Type GetRequestType()
        {
            return typeof(EthGasPrice);
        }
    }
}