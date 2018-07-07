using System;
using Loom.Nethereum.JsonRpc.Client;

namespace Loom.Nethereum.ENS.IntegrationTests
{
    public class ClientFactory
    {
        public static IClient GetClient()
        {
//#if NET462
           // var client = new IpcClient("geth.ipc");
            //return client;
//#else      
          return new RpcClient(new Uri("http://localhost:8545/"));
//#endif
           
        }
    }
}
