using System;
using Loom.Nethereum.JsonRpc.Client;

namespace Loom.Nethereum.Accounts.IntegrationTests
{
    public class ClientFactory
    {
        public static IClient GetClient()
        {
            return new RpcClient(new Uri("http://localhost:8545"));
        }
    }
}