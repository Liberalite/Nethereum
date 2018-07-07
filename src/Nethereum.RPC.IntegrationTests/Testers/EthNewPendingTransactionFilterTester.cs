using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Eth.Filters;

namespace Loom.Nethereum.RPC.Tests.Testers
{
    public class EthNewPendingTransactionFilterTester : IRPCRequestTester
    {
        public async Task<object> ExecuteTestAsync(IClient client)
        {
            var ethNewPendingTransactionFilter = new EthNewPendingTransactionFilter(client);
            return await ethNewPendingTransactionFilter.SendRequestAsync();
        }

        public Type GetRequestType()
        {
            return typeof (EthNewPendingTransactionFilter);
        }
    }
}