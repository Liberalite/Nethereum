using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;

namespace Loom.Nethereum.Geth.RPC.Debug
{
    /// <Summary>
    ///     Turns on Go runtime tracing for the given duration and writes trace data to disk.
    /// </Summary>
    public class DebugGoTrace : RpcRequestResponseHandler<object>
    {
        public DebugGoTrace(IClient client) : base(client, ApiMethods.debug_goTrace.ToString())
        {
        }

        public RpcRequest BuildRequest(string fileName, int seconds, object id = null)
        {
            return base.BuildRequest(id, fileName, seconds);
        }

        public Task<object> SendRequestAsync(string fileName, int seconds, object id = null)
        {
            return base.SendRequestAsync(id, fileName, seconds);
        }
    }
}