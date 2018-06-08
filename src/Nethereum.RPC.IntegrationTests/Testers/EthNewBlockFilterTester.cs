using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Eth.Filters;

namespace Loom.Nethereum.RPC.Tests.Testers
{
    public class EthNewBlockFilterTester : IRPCRequestTester
    {
        public async Task<object> ExecuteTestAsync(IClient client)
        {
            var ethNewBlockFilter = new EthNewBlockFilter(client);
            return await ethNewBlockFilter.SendRequestAsync();
        }

        public Type GetRequestType()
        {
            return typeof (EthNewBlockFilter);
        }
    }
}