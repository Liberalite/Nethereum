﻿using System.Threading;
using System.Threading.Tasks;
using Loom.Nethereum.Hex.HexTypes;
using Loom.Nethereum.RPC.Eth.DTOs;

namespace Loom.Nethereum.Contracts.CQS
{
#if !DOTNET35
    public abstract class ContractTransactionHandlerBase<TFunctionDTO> : ContractHandlerBase<TFunctionDTO>
        where TFunctionDTO : ContractMessage
    {
        protected virtual async Task<HexBigInteger> GetOrEstimateMaximumGas(TFunctionDTO functionMessage)
        {
            var maxGas = functionMessage.GetHexMaximumGas();

            if (maxGas == null)
                maxGas = await EstimateGasAsync(functionMessage).ConfigureAwait(false);

            return maxGas;
        }

        protected abstract Task<HexBigInteger> EstimateGasAsync(TFunctionDTO functionMessage);

        protected abstract Task<TransactionReceipt> ExecuteTransactionAsync(TFunctionDTO functionMessage,
            HexBigInteger gasEstimate, CancellationTokenSource tokenSource = null);
    }
#endif
}