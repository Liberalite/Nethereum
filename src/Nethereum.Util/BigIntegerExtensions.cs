using System;
using Org.BouncyCastle.Math;

namespace Loom.Nethereum.Util
{
    public static class BigIntegerExtensions
    {
        public static int NumberOfDigits(this BigInteger value)
        {
            return value.ToString().Length;
        }

        public static decimal ToDecimal(this BigInteger value)
        {
            if (value.SignValue == 0)
                return Decimal.Zero;

            byte[] dataTemp = value.ToByteArrayUnsigned();
            byte[] data = new byte[12];
            Array.Copy(dataTemp, data, dataTemp.Length);

            if (data.Length > 12)
                throw new OverflowException ();

            int lo = 0, mi = 0, hi = 0;
            if (data.Length > 8)
                hi = BitConverter.ToInt32(data, 8);
            if (data.Length > 4)
                mi = BitConverter.ToInt32(data, 4);
            if (data.Length > 0)
                lo = BitConverter.ToInt32(data, 0);

            return new Decimal(lo, mi, hi, value.SignValue < 0, 0);
        }
    }
}