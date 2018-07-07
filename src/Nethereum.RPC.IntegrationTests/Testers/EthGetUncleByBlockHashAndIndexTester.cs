using System;
using System.Threading.Tasks;
using Loom.Nethereum.Hex.HexTypes;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Eth.DTOs;
using Loom.Nethereum.RPC.Eth.Uncles;
using Xunit;

namespace Loom.Nethereum.RPC.Tests.Testers
{
    public class EthGetUncleByBlockHashAndIndexTester : RPCRequestTester<BlockWithTransactionHashes>, IRPCRequestTester
    {
        public EthGetUncleByBlockHashAndIndexTester():base()
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
            var ethGetUncleByBlockHashAndIndex = new EthGetUncleByBlockHashAndIndex(client);
            return
                await
                    ethGetUncleByBlockHashAndIndex.SendRequestAsync(
                        "0x84e538e6da2340e3d4d90535f334c22974fecd037798d1cf8965c02e8ab3394b", new HexBigInteger(0));
        }

        public override Type GetRequestType()
        {
            return typeof(EthGetUncleByBlockHashAndIndex);
        }
    }
}