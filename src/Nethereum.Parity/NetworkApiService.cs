using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.Parity.RPC.Network;
using Loom.Nethereum.RPC;

namespace Loom.Nethereum.Parity
{
    public class NetworkApiService : RpcClientWrapper
    {
        public NetworkApiService(IClient client) : base(client)
        {
            ChainStatus = new ParityChainStatus(client);
            GasPriceHistogram = new ParityGasPriceHistogram(client);
            NetPeers = new ParityNetPeers(client);
            NetPort = new ParityNetPort(client);
            PendingTransactions = new ParityPendingTransactions(client);
        }

        public ParityChainStatus ChainStatus { get; }
        public ParityGasPriceHistogram GasPriceHistogram { get; }
        public ParityNetPeers NetPeers { get; }
        public ParityNetPort NetPort { get; }
        public ParityPendingTransactions PendingTransactions { get; }
    }
}