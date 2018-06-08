using Loom.Nethereum.RPC.Eth.DTOs;

namespace Loom.Nethereum.Contracts
{
    public interface IEventLog
    {
        FilterLog Log { get; }
    }
}