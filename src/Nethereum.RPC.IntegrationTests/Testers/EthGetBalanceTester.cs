using System;
using System.Threading.Tasks;
using Loom.Nethereum.Hex.HexTypes;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Eth;
using Loom.Nethereum.RPC.Eth.Blocks;
using Loom.Nethereum.RPC.Eth.DTOs;
using Loom.Nethereum.RPC.Tests.Testers;
using Xunit;

namespace Loom.Nethereum.RPC.Tests.Testers
{
    public class EthGetBalanceTester : RPCRequestTester<HexBigInteger>, IRPCRequestTester
    {
        [Fact]
        public async void ShouldReturnBalanceBiggerThanZero()
        {
            var result = await ExecuteAsync();
            //Default account has balance
            Assert.True(result.Value > 0);
        }

        [Fact]  
        public async void ShouldReturnBalanceBiggerThanZeroForCurrentBlock()
        {
            var blockNumber = await (new EthBlockNumber(Client)).SendRequestAsync();
            var ethGetBalance = new EthGetBalance(Client);
            var result = await ethGetBalance.SendRequestAsync(Settings.GetDefaultAccount(), new BlockParameter(blockNumber));
            //Default account has balance
            Assert.True(result.Value > 0);
        }

        public override async Task<HexBigInteger> ExecuteAsync(IClient client)
        {
            var ethGetBalance = new EthGetBalance(client);
            return await ethGetBalance.SendRequestAsync(Settings.GetDefaultAccount());
        }

        public override Type GetRequestType()
        {
            return typeof(EthGetBalance);
        }
    }
}

