using Loom.Nethereum.JsonRpc.Client;
//using Nethereum.JsonRpc.IpcClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loom.Nethereum.RPC.Tests.Testers;

namespace Loom.Nethereum.RPC.Tests
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
