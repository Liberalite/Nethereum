using System;
using System.Threading.Tasks;
using Loom.Nethereum.Hex.HexTypes;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Eth.Blocks;
using Loom.Nethereum.RPC.Eth.DTOs;
using Xunit;

namespace Loom.Nethereum.RPC.Tests.Testers
{
    public class EthGetBlockTransactionCountByNumberTester : RPCRequestTester<HexBigInteger>
    {
        [Fact]
        public async void ShouldReturnTransactionCount()
        {
            var result = await ExecuteAsync();
            Assert.NotNull(result);
            //we have configured one transaction at least for this block
            Assert.True(result.Value > 0);
        }

        public override async Task<HexBigInteger> ExecuteAsync(IClient client)
        {
            var ethGetBlockTransactionCountByNumber = new EthGetBlockTransactionCountByNumber(client);
            return await ethGetBlockTransactionCountByNumber.SendRequestAsync(new BlockParameter(Settings.GetBlockNumber()));
        }

        public override Type GetRequestType()
        {
            return typeof (EthGetBlockTransactionCountByNumber);
        }
    }
}