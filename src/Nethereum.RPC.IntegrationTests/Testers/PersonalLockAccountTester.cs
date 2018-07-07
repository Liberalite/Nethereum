using System;
using System.Threading.Tasks;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Personal;
using Xunit;

namespace Loom.Nethereum.RPC.Tests.Testers
{
    public class PersonalLockAccountTester : RPCRequestTester<bool>, IRPCRequestTester
    {
        
        [Fact]
        public async void ShouldLockAccountAndReturnTrue()
        {
            var result = await ExecuteAsync();
            Assert.True(result);
        }

        public override async Task<bool> ExecuteAsync(IClient client)
        {
            var personalLockAccount = new PersonalLockAccount(client);
            return await personalLockAccount.SendRequestAsync(Settings.GetDefaultAccount());
        }

        public override Type GetRequestType()
        {
            return typeof(PersonalLockAccount);
        }
    }
}
        