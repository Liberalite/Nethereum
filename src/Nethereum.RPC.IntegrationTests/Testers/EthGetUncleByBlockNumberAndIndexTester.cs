using System;
using System.Threading.Tasks;
using Loom.Nethereum.Hex.HexTypes;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Eth.DTOs;
using Loom.Nethereum.RPC.Eth.Uncles;
using Xunit;

namespace Loom.Nethereum.RPC.Tests.Testers
{
    public class EthGetUncleByBlockNumberAndIndexTester : RPCRequestTester<BlockWithTransactionHashes>, IRPCRequestTester
    {
        public EthGetUncleByBlockNumberAndIndexTester():base()
        {
            this.Client = new RpcClient(new Uri(Settings.GetLiveRpcUrl()));
        }

        [Fact]
        public async void ShoulRetrieveUncleWithTransactionHashes()
        {
            var uncle = await ExecuteAsync();
            Assert.NotNull(uncle);
        }

        public override async Task<BlockWithTransactionHashes> ExecuteAsync(IClient client)
        {
            //https://etherscan.io/block/668
            var ethGetUncleByBlockNumberAndIndex = new EthGetUncleByBlockNumberAndIndex(client);
            return
                await
                    ethGetUncleByBlockNumberAndIndex.SendRequestAsync(
                        new BlockParameter(668), new HexBigInteger(0));
        }

        public override Type GetRequestType()
        {
            return typeof(EthGetUncleByBlockNumberAndIndex);
        }
    }
}