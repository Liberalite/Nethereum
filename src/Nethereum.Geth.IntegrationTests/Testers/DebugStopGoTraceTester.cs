using System;
using System.Threading.Tasks;
using Loom.Nethereum.Geth.RPC.Debug;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Tests.Testers;
using Xunit;

namespace Loom.Nethereum.Geth.Tests.Testers
{
    public class DebugStopGoTraceTester : RPCRequestTester<object>, IRPCRequestTester
    {
        public override async Task<object> ExecuteAsync(IClient client)
        {
            var debugStopGoTrace = new DebugStopGoTrace(client);
            return await debugStopGoTrace.SendRequestAsync();
        }

        public override Type GetRequestType()
        {
            return typeof(DebugStopGoTrace);
        }

        [Fact]
        public async void ShouldAlwaysReturnNull()
        {
            var result = await ExecuteAsync();
            Assert.Null(result);
        }
    }
}