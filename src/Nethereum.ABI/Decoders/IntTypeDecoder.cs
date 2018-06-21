using System;
using System.Linq;
using Loom.Nethereum.Hex.HexConvertors.Extensions;
using Org.BouncyCastle.Math;

namespace Loom.Nethereum.ABI.Decoders
{
    public class IntTypeDecoder : TypeDecoder
    {
        public override object Decode(byte[] encoded, Type type)
        {
            if (type == typeof(byte))
                return DecodeByte(encoded);

            if (type == typeof(sbyte))
                return DecodeSbyte(encoded);

            if (type == typeof(short))
                return DecodeShort(encoded);

            if (type == typeof(ushort))
                return DecodeUShort(encoded);

            if (type == typeof(int))
                return DecodeInt(encoded);

            if (type == typeof(uint))
                return DecodeUInt(encoded);

            if (type == typeof(long))
                return DecodeLong(encoded);

            if (type == typeof(ulong))
                return DecodeULong(encoded);

            if ((type == typeof(BigInteger)) || (type == typeof(object)))
                return DecodeBigInteger(encoded);

            throw new NotSupportedException(type + " is not a supported decoding type for IntType");
        }

        public BigInteger DecodeBigInteger(string hexString)
        {
            if (!hexString.StartsWith("0x"))
                hexString = "0x" + hexString;

            return DecodeBigInteger(hexString.HexToByteArray());
        }

        public BigInteger DecodeBigInteger(byte[] encoded)
        {
            var negative = encoded.First() == 0xFF;

            if (!BitConverter.IsLittleEndian)
                encoded = encoded.Reverse().ToArray();

            return new BigInteger(negative ? -1 : 1, encoded);
        }

        public byte DecodeByte(byte[] encoded)
        {
            return (byte)DecodeBigInteger(encoded).IntValue;
        }

        public sbyte DecodeSbyte(byte[] encoded)
        {
            return (sbyte)DecodeBigInteger(encoded).IntValue;
        }

        public short DecodeShort(byte[] encoded)
        {
            return (short)DecodeBigInteger(encoded).IntValue;
        }

        public ushort DecodeUShort(byte[] encoded)
        {
            return (ushort)DecodeBigInteger(encoded).IntValue;
        }

        public int DecodeInt(byte[] encoded)
        {
            return DecodeBigInteger(encoded).IntValue;
        }

        public long DecodeLong(byte[] encoded)
        {
            return DecodeBigInteger(encoded).LongValue;
        }

        public uint DecodeUInt(byte[] encoded)
        {
            return (uint) DecodeBigInteger(encoded).LongValue;
        }

        public ulong DecodeULong(byte[] encoded)
        {
            return (ulong) DecodeBigInteger(encoded).LongValue;
        }

        public override Type GetDefaultDecodingType()
        {
            return typeof(BigInteger);
        }

        public override bool IsSupportedType(Type type)
        {
            return (type == typeof(int)) || (type == typeof(uint)) ||
                   (type == typeof(ulong)) || (type == typeof(long))  ||
                   (type == typeof(short)) || (type == typeof(ushort)) ||
                   (type == typeof(byte)) || (type == typeof(sbyte)) ||
                   (type == typeof(BigInteger)) || (type == typeof(object)) ;
        }
    }
}