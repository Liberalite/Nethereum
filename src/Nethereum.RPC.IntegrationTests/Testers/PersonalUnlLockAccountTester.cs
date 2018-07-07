using System;
using System.Threading.Tasks;
using Loom.Nethereum.Hex.HexTypes;
using Loom.Nethereum.JsonRpc.Client;
using Loom.Nethereum.RPC.Personal;
using Xunit;

namespace Loom.Nethereum.RPC.Tests.Testers
{
    public class PersonalUnlLockAccountTester : RPCRequestTester<bool>, IRPCRequestTester
    {

        [Fact]
        public async void ShouldUnLockAccountAndReturnTrue()
        {
            var result = await ExecuteAsync();
            Assert.True(result);
        }

        public override async Task<bool> ExecuteAsync(IClient client)
        {
            var personalunlockAccount = new PersonalUnlockAccount(client);
            ulong? duration = null;
            await personalunlockAccount.SendRequestAsync(Settings.GetDefaultAccount(), Settings.GetDefaultAccountPassword(), duration);
            if (Settings.IsParity())
            {
                //Parity
                return
                    await
                        personalunlockAccount.SendRequestAsync(Settings.GetDefaultAccount(),
                            Settings.GetDefaultAccountPassword(), new HexBigInteger(30));
            }
            else
            {
                return
                    await
                        personalunlockAccount.SendRequestAsync(Settings.GetDefaultAccount(),
                            Settings.GetDefaultAccountPassword(), 30);
            }
        }

        public override Type GetRequestType()
        {
            return typeof(PersonalUnlockAccount);
        }
    }
}