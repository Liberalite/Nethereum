﻿using System.Numerics;
using Loom.Nethereum.KeyStore;
using Loom.Nethereum.RPC.Accounts;
using Loom.Nethereum.RPC.NonceServices;
using Loom.Nethereum.RPC.TransactionManagers;
using Loom.Nethereum.Signer;

namespace Loom.Nethereum.Web3.Accounts
{
    public class Account : IAccount
    {
        public BigInteger? ChainId { get; }

#if !PCL
        public static Account LoadFromKeyStoreFile(string filePath, string password)
        {
            var keyStoreService = new Nethereum.KeyStore.KeyStoreService();
            var key = keyStoreService.DecryptKeyStoreFromFile(password, filePath);
            return new Account(key);
        }
#endif
        public static Account LoadFromKeyStore(string json, string password, BigInteger? chainId = null)
        {
            var keyStoreService = new KeyStoreService();
            var key = keyStoreService.DecryptKeyStoreFromJson(password, json);
            return new Account(key, chainId);
        }

        public string PrivateKey { get; private set; }

        public Account(EthECKey key, BigInteger? chainId = null)
        {
            ChainId = chainId;
            Initialise(key);
        }

        public Account(string privateKey, BigInteger? chainId = null)
        {
            ChainId = chainId;
            Initialise(new EthECKey(privateKey));
        }

        public Account(byte[] privateKey, BigInteger? chainId = null)
        {
            ChainId = chainId;
            Initialise(new EthECKey(privateKey, true));
        }

        public Account(EthECKey key, Chain chain) : this(key, (int) chain)
        {
        }

        public Account(string privateKey, Chain chain) : this(privateKey, (int) chain)
        {
        }

        public Account(byte[] privateKey, Chain chain) : this(privateKey, (int) chain)
        {
        }

        private void Initialise(EthECKey key)
        {
            PrivateKey = key.GetPrivateKey();
            Address = key.GetPublicAddress();
            InitialiseDefaultTransactionManager();
        }

        protected virtual void InitialiseDefaultTransactionManager()
        {
            TransactionManager = new AccountSignerTransactionManager(null, this, ChainId);
        }

        public string Address { get; protected set; }
        public ITransactionManager TransactionManager { get; protected set; }
        public INonceService NonceService { get; set; }
    }
}