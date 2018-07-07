using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Infrastructure;

namespace Loom.Nethereum.Geth.RPC.Debug
{
    /// <Summary>
    ///     Stops an ongoing CPU profile.
    /// </Summary>
    public class DebugStopCPUProfile : GenericRpcRequestResponseHandlerNoParam<object>
    {
        public DebugStopCPUProfile(IClient client) : base(client, ApiMethods.debug_stopCPUProfile.ToString())
        {
        }
    }
}