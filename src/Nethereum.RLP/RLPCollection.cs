using System.Collections.Generic;

namespace Loom.Nethereum.RLP
{
    public class RLPCollection : List<IRLPElement>, IRLPElement
    {
        public byte[] RLPData { get; set; }
    }
}