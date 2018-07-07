using Loom.Nethereum.RPC.Eth.DTOs;

namespace Loom.Nethereum.RPC.Eth
{
    public interface IDefaultBlock
    {
        BlockParameter DefaultBlock { get; set; }
    }
}