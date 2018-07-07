using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Eth;
using Loom.Nethereum.RPC.Eth.Compilation;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Loom.Nethereum.RPC.Tests.Testers
{
  
    public class EthCoinBaseTester : RPCRequestTester<string>, IRPCRequestTester
    {
        [Fact]
        public async void ShouldReturnCoinBaseAccount()
        {
            var result = await ExecuteAsync();
            Assert.NotNull(result);
        }

        public override async Task<string> ExecuteAsync(IClient client)
        {
            var ethCoinBase = new EthCoinBase(client);
            return await ethCoinBase.SendRequestAsync();
        }

        public override Type GetRequestType()
        {
            return typeof(EthCoinBase);
        }
    }
}