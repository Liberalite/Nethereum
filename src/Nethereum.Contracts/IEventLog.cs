using Loom.Nethereum.RPC.Eth.DTOs;

namespace Loom.Nethereum.Contracts
{

    public interface IEventDTO
    {

    }

    public interface IFunctionOutputDTO
    {

    }

    public interface IEventLog
    {
        FilterLog Log { get; }
    }
}