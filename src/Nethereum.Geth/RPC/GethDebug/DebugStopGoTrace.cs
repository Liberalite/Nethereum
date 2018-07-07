using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Infrastructure;

namespace Nethereum.Geth.RPC.Debug
{
    /// <Summary>
    ///     Stops writing the Go runtime trace.
    /// </Summary>
    public class DebugStopGoTrace : GenericRpcRequestResponseHandlerNoParam<object>
    {
        public DebugStopGoTrace(IClient client) : base(client, ApiMethods.debug_stopGoTrace.ToString())
        {
        }
    }
}