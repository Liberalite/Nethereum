using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;

namespace Loom.Nethereum.RPC.Tests.Testers
{
    public abstract class RPCRequestTester<T>: IRPCRequestTester
    {
        public IClient Client { get; set; }
        public TestSettings Settings { get; set; }

        protected RPCRequestTester()
        {
            Settings = new TestSettings();
            Client = ClientFactory.GetClient(Settings);
        }

        public Task<T> ExecuteAsync()
        {
            return ExecuteAsync(Client);
        }

        public async Task<object> ExecuteTestAsync(IClient client)
        {
            return await ExecuteAsync(client);
        }

        public abstract Task<T> ExecuteAsync(IClient client);

        public abstract Type GetRequestType();
    }
}