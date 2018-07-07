using System;
using System.Threading.Tasks;
using Loom.Nethereum.Geth.RPC.Debug;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Tests.Testers;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Loom.Nethereum.Geth.Tests.Testers
{
    public class DebugTraceBlockFromFileTester : RPCRequestTester<JObject>, IRPCRequestTester
    {
        public override Type GetRequestType()
        {
            return typeof(DebugTraceBlockFromFile);
        }

        //[Fact] TODO: Refactor test
        public async void ShouldAlwaysReturnNull()
        {
            var result = await ExecuteAsync();
            Assert.Null(result);
        }

        public override async Task<JObject> ExecuteAsync(IClient client)
        {
            var debugTraceBlockFromFile = new DebugTraceBlockFromFile(client);
            return await debugTraceBlockFromFile.SendRequestAsync(Settings.GetDefaultLogLocation());
        }
    }
}