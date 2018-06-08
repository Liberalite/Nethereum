using System;
using System.Threading.Tasks;
using Loom.Nethereum.Hex.HexTypes;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Eth.Mining;
using Xunit;

namespace Loom.Nethereum.RPC.Tests.Testers
{
    public class EthHashrateTester : RPCRequestTester<HexBigInteger>, IRPCRequestTester
    {
        [Fact]
        public async void ShouldReturnHashRate()
        {
            var result = await ExecuteAsync();
            //We should not be mining so hash rate is 0
            Assert.Equal("0x0", result.HexValue);
        }

        public override async Task<HexBigInteger> ExecuteAsync(IClient client)
        {
            var minerHashrate = new EthHashrate(client);
            return await minerHashrate.SendRequestAsync();
        }

        public override Type GetRequestType()
        {
            return typeof(EthHashrate);
        }
    }
}