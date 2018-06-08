using System;
using System.Threading.Tasks;
using Loom.Nethereum.Geth.RPC.Debug;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Tests.Testers;
using Xunit;

namespace Loom.Nethereum.Geth.Tests.Testers
{
    public class DebugVerbosityTester : RPCRequestTester<object>, IRPCRequestTester
    {
        public override async Task<object> ExecuteAsync(IClient client)
        {
            var debugVerbosity = new DebugVerbosity(client);
            return await debugVerbosity.SendRequestAsync(5);
        }

        public override Type GetRequestType()
        {
            return typeof(DebugVerbosity);
        }

        [Fact]
        public async void ShouldSetTheVerbosityAndReturnNull()
        {
            var result = await ExecuteAsync();
            Assert.Null(result);
        }
    }
}