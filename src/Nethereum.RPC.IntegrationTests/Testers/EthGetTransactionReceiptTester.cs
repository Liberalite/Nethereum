using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Eth.DTOs;
using Loom.Nethereum.RPC.Eth.Transactions;
using Xunit;

namespace Loom.Nethereum.RPC.Tests.Testers
{
    public class EthGetTransactionReceiptTester : RPCRequestTester<TransactionReceipt>, IRPCRequestTester
    {
        [Fact]
        public async void ShouldRetrieveReceipt()
        {
            var receipt = await ExecuteAsync();
            Assert.NotNull(receipt);
        }

        public override async Task<TransactionReceipt> ExecuteAsync(IClient client)
        {
            var ethGetTransactionByHash = new EthGetTransactionReceipt(client);
            return
                await
                    ethGetTransactionByHash.SendRequestAsync(
                        Settings.GetTransactionHash());
        }

        public override Type GetRequestType()
        {
            return typeof(EthGetTransactionReceipt);
        }
    }
}