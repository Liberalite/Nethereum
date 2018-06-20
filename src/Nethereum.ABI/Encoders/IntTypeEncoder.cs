using System;
using System.Linq;
using Loom.Nethereum.ABI.Decoders;
using Loom.Nethereum.ABI.Util;
using Org.BouncyCastle.Math;

namespace Loom.Nethereum.ABI.Encoders
{
    public class IntTypeEncoder : ITypeEncoder
    {
        private readonly IntTypeDecoder intTypeDecoder;

        public IntTypeEncoder()
        {
            intTypeDecoder = new IntTypeDecoder();
        }

        public byte[] Encode(object value)
        {
            BigInteger bigInt;

            var stringValue = value as string;

            if (stringValue != null)
                bigInt = intTypeDecoder.Decode<BigInteger>(stringValue);
            else if (value is BigInteger)
                bigInt = (BigInteger) value;
            else if (value.IsNumber())
                bigInt = new BigInteger(value.ToString());
            else
                throw new Exception("Invalid value for type '" + this + "': " + value + " (" + value.GetType() + ")");
            return EncodeInt(bigInt);
        }

        public byte[] EncodeInt(int value)
        {
            return EncodeInt(BigInteger.ValueOf(value));
        }

        public byte[] EncodeInt(BigInteger value)
        {
            const int maxIntSizeInBytes = 32;
            //It should always be Big Endian.
            var bytes = BitConverter.IsLittleEndian
                            ? value.ToByteArray().Reverse().ToArray()
                            : value.ToByteArray();

            if (bytes.Length > maxIntSizeInBytes)
                throw new ArgumentOutOfRangeException(nameof(value),
                                                      $"Integer value must not exceed maximum Solidity size of {maxIntSizeInBytes} bytes. Length of passed value is {bytes.Length}");

            var ret = new byte[maxIntSizeInBytes];

            for (var i = 0; i < ret.Length; i++)
                if (value.SignValue < 0)
                    ret[i] = 0xFF;
                else
                    ret[i] = 0;

            Array.Copy(bytes, 0, ret, maxIntSizeInBytes - bytes.Length, bytes.Length);

            return ret;
        }
    }
}