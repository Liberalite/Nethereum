using Loom.Nethereum.Geth.RPC.Miner;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC;

namespace Loom.Nethereum.Geth
{
    public class MinerApiService : RpcClientWrapper
    {
        public MinerApiService(IClient client) : base(client)
        {
            SetGasPrice = new MinerSetGasPrice(client);
            Start = new MinerStart(client);
            Stop = new MinerStop(client);
        }

        public MinerSetGasPrice SetGasPrice { get; }
        public MinerStart Start { get; }
        public MinerStop Stop { get; }
    }
}