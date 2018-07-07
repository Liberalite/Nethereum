using System.Threading.Tasks;
using Loom.Nethereum.RPC.Eth.DTOs;

namespace Loom.Nethereum.Contracts.CQS
{
    public interface IContractQueryHandler<TContractMessage> where TContractMessage : ContractMessage
    {
        Task<TFunctionOutput> QueryAsync<TFunctionOutput>(TContractMessage contractFunctionMessage, string contractAddress, BlockParameter block = null);
        Task<TFunctionOutput> QueryDeserializingToObjectAsync<TFunctionOutput>(TContractMessage contractFunctionMessage, string contractAddress, BlockParameter block = null) where TFunctionOutput : new();
        Task<byte[]> QueryRawAsBytesAsync(TContractMessage contractFunctionMessage, string contractAddress, BlockParameter block = null);
        Task<string> QueryRawAsync(TContractMessage contractFunctionMessage, string contractAddress, BlockParameter block = null);
    }
}