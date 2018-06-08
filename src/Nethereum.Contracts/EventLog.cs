using Loom.Nethereum.RPC.Eth.DTOs;

namespace Loom.Nethereum.Contracts
{
    public class EventLog<T> : IEventLog
    {
        public EventLog(T eventObject, FilterLog log)
        {
            Event = eventObject;
            Log = log;
        }

        public T Event { get; }
        public FilterLog Log { get; }
    }
}