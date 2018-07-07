using System;
using Loom.Nethereum.JsonRpc.Client;

namespace Loom.Nethereum.Parity.IntegrationTests
{
    public class ClientFactory
    {
        public static IClient GetClient(TestSettings settings)
        {
            var url = settings.GetRPCUrl();
            return new RpcClient(new Uri(url));
        }
    }
}