using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Eth;

namespace Loom.Nethereum.RPC.Tests.Testers
{
    public class EthSignTester : RPCRequestTester<string>, IRPCRequestTester
    {
        public override async Task<string> ExecuteAsync(IClient client)
        {
            var ethSign = new EthSign(client);
            return await ethSign.SendRequestAsync("0x12890d2cce102216644c59dae5baed380d84830c", "Hello world");
        }

        public override Type GetRequestType()
        {
            return typeof (EthSign);
        }
    }
}