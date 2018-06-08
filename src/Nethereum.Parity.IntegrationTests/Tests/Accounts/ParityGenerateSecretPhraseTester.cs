using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.Parity.RPC.Accounts;
using Xunit;

namespace Loom.Nethereum.Parity.IntegrationTests.Tests.Accounts
{
    public class ParityGenerateSecretPhraseTester : RPCRequestTester<string>, IRPCRequestTester
    {
        public override async Task<string> ExecuteAsync(IClient client)
        {
            var parityGenerateSecretPhrase = new ParityGenerateSecretPhrase(client);
            return await parityGenerateSecretPhrase.SendRequestAsync();
        }

        public override Type GetRequestType()
        {
            return typeof(ParityGenerateSecretPhrase);
        }

        [Fact]
        public async void ShouldGenerateSecretePhrase()
        {
            var result = await ExecuteAsync();
            Assert.NotNull(result);
        }
    }
}