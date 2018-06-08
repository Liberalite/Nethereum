using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Eth.Mining;

namespace Loom.Nethereum.RPC.Tests.Testers
{
    public class EthMiningTester : IRPCRequestTester
    {
        public async Task<object> ExecuteTestAsync(IClient client)
        {
            var ethMining = new EthMining(client);
            return await ethMining.SendRequestAsync();
        }

        public Type GetRequestType()
        {
            return typeof (EthMining);
        }
    }
}