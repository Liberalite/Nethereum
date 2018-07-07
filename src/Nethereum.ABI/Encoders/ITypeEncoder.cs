namespace Loom.Nethereum.ABI.Encoders
{
    public interface ITypeEncoder
    {
        byte[] Encode(object value);
    }
}