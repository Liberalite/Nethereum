using System;
using Loom.Nethereum.RPC.Eth.DTOs;

namespace Loom.Nethereum.RPC.Eth.Exceptions
{
    public class ContractDeploymentException : Exception
    {
        public ContractDeploymentException(string message, TransactionReceipt transactionReceipt) : base(message)
        {
            TransactionReceipt = transactionReceipt;
        }

        public TransactionReceipt TransactionReceipt { get; set; }
    }
}