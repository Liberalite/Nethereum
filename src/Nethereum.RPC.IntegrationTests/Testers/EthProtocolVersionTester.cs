using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Eth;

namespace Loom.Nethereum.RPC.Tests.Testers
{
    public class EthProtocolVersionTester : IRPCRequestTester
    {
        public async Task<object> ExecuteTestAsync(IClient client)
        {
            var ethProtocolVersion = new EthProtocolVersion(client);
            return await ethProtocolVersion.SendRequestAsync();
        }

        public Type GetRequestType()
        {
            return typeof (EthProtocolVersion);
        }
    }
}