using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;

namespace Loom.Nethereum.RPC.Tests.Testers
{
    public interface IRPCRequestTester
    {
        Task<object> ExecuteTestAsync(IClient client);
        Type GetRequestType();
    }
}