using Loom.Nethereum.RPC.Eth.DTOs;

namespace Loom.Nethereum.Contracts.CQS
{
    public interface IContractMessageTransactionInputCreator<TContractMessage> where TContractMessage : ContractMessage
    {
        TransactionInput CreateTransactionInput(TContractMessage contractMessage);
        CallInput CreateCallInput(TContractMessage contractMessage);
        string DefaultAddressFrom { get; set; }
    }
}