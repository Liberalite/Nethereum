using System;
using System.Threading.Tasks;
using Loom.Nethereum.Hex.HexTypes;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Web3;

namespace Loom.Nethereum.RPC.Tests.Testers
{
    public class Web3Sha3Tester : IRPCRequestTester
    {
        public async Task<object> ExecuteTestAsync(IClient client)
        {
            var web3Sha3 = new Web3Sha3(client);
            return await web3Sha3.SendRequestAsync(new HexUTF8String("Monkey"));
        }

        public Type GetRequestType()
        {
            return typeof (Web3Sha3Tester);
        }
    }
}