using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Web3;

namespace Loom.Nethereum.RPC.Tests.Testers
{
    public class Web3ClientVersionTester : IRPCRequestTester
    {
        public async Task<object> ExecuteTestAsync(IClient client)
        {
            var web3ClientVersion = new Web3ClientVersion(client);
            return await web3ClientVersion.SendRequestAsync();
        }

        public Type GetRequestType()
        {
            return typeof (Web3ClientVersion);
        }
    }
}