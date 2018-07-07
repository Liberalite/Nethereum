using Loom.Nethereum.RPC.TransactionManagers;
using System;
using System.Collections.Generic;
using System.Text;
using Loom.Nethereum.RPC.NonceServices;

namespace Loom.Nethereum.RPC.Accounts
{
    public interface IAccount
    {
        string Address { get; }
        ITransactionManager TransactionManager { get; }

        INonceService NonceService { get; set; }
    }
}
