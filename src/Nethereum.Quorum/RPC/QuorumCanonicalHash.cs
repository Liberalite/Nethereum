﻿using System;
using System.Threading.Tasks;
using Loom.Nethereum.Hex.HexTypes;
using Loom.Nethereum.JsonRpc.Client;

namespace Nethereum.Quorum.RPC
{
    public class QuorumCanonicalHash : RpcRequestResponseHandler<string>
    {
        public QuorumCanonicalHash(IClient client) : base(client, ApiMethods.quorum_canonicalHash.ToString())
        {
        }

        public Task<string> SendRequestAsync(long blockNumber, object id = null)
        {
            return base.SendRequestAsync(id, blockNumber);
        }

        public RpcRequest BuildRequest(long blockNumber, object id = null)
        {
            return base.BuildRequest(id, blockNumber);
        }
    }
}