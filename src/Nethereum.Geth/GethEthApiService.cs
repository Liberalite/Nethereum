using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC;
using Loom.Nethereum.RPC.Eth.Transactions;

namespace Loom.Nethereum.Geth
{
    public class GethEthApiService : RpcClientWrapper
    {
        public GethEthApiService(IClient client) : base(client)
        {
            PendingTransactions = new EthPendingTransactions(client);
        }

        public EthPendingTransactions PendingTransactions { get; }
    }
}