using System;
using System.Threading.Tasks;
using Loom.Nethereum.Hex.HexTypes;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.Parity.RPC.BlockAuthoring;
using Xunit;

namespace Loom.Nethereum.Parity.IntegrationTests.Tests.BlockAuthoring
{
    public class ParityGasFloorTargetTester : RPCRequestTester<HexBigInteger>, IRPCRequestTester
    {
        public override async Task<HexBigInteger> ExecuteAsync(IClient client)
        {
            var parityGasFloorTarget = new ParityGasFloorTarget(client);
            return await parityGasFloorTarget.SendRequestAsync();
        }

        public override Type GetRequestType()
        {
            return typeof(ParityGasFloorTarget);
        }

        [Fact]
        public async void ShouldGetGasFloorTarget()
        {
            var result = await ExecuteAsync();
            Assert.NotNull(result);
        }
    }
}