using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Infrastructure;

namespace Loom.Nethereum.Geth.RPC.Miner
{
    /// <Summary>
    ///     Stop the CPU mining operation.
    /// </Summary>
    public class MinerStop : GenericRpcRequestResponseHandlerNoParam<bool>
    {
        public MinerStop(IClient client) : base(client, ApiMethods.miner_stop.ToString())
        {
        }
    }
}