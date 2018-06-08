using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;

namespace Loom.Nethereum.Parity.IntegrationTests
{
    public interface IRPCRequestTester
    {
        Task<object> ExecuteTestAsync(IClient client);
        Type GetRequestType();
    }
}