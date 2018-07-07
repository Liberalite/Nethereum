using System.Threading.Tasks;
using Loom.Nethereum.RPC.Eth.DTOs;

namespace Loom.Nethereum.Contracts.CQS
{
    public interface IQueryHandlerPreRequestHandler<TContractMessage> where TContractMessage : ContractMessage
    {
        Task ExecuteAsync(TContractMessage contractMessage, string contractAddress, BlockParameter block);
    }
}