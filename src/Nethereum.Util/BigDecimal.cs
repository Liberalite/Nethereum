using System;
using System.Globalization;
using Org.BouncyCastle.Math;

namespace Loom.Nethereum.Util
{
    /// BigNumber based on the original http://uberscraper.blogspot.co.uk/2013/09/c-bigdecimal-class-from-stackoverflow.html
    /// which was inspired by http://stackoverflow.com/a/4524254
    /// Original Author: Jan Christoph Bernack (contact: jc.bernack at googlemail.com)
    /// Changes JB: Added parse, Fix Normalise, Added Floor, New ToString, Change Equals (normalise to validate first), Change Casting to avoid overflows (even if might be slower), Added Normalise Bigger than zero, test on operations, parsing, casting, and other test coverage for ethereum unit conversions
    /// Changes KJ: Added Culture formatting
    /// http://stackoverflow.com/a/13813535/956364" />
    /// <summary>
    ///     Arbitrary precision Decimal.
    ///     All operations are exact, except for division.
    ///     Division never determines more digits than the given precision of 50.
    /// </summary>
    public struct BigDecimal : IComparable, IComparable<BigDecimal>
    {
        /// <summary>
        ///     Sets the maximum precision of division operations.
        ///     If AlwaysTruncate is set to true all operations are affected.
        /// </summary>
        public const int Precision = 50;

        public BigDecimal(BigDecimal bigDecimal, bool alwaysTruncate = false) : this(bigDecimal.Mantissa,
            bigDecimal.Exponent, alwaysTruncate)
        {
        }

        public BigDecimal(decimal value, bool alwaysTruncate = false) : this((BigDecimal) value, alwaysTruncate)
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="mantissa"></param>
        /// <param name="exponent">
        ///     The number of decimal units for example (-18). A positive value will be normalised as 10 ^
        ///     exponent
        /// </param>
        /// <param name="alwaysTruncate">
        ///     Specifies whether the significant digits should be truncated to the given precision after
        ///     each operation.
        /// </param>
        public BigDecimal(BigInteger mantissa, int exponent, bool alwaysTruncate = false) : this()
        {
            Mantissa = mantissa;
            Exponent = exponent;
            NormaliseExponentBiggerThanZero();
            Normalize();
            if (alwaysTruncate)
                Truncate();
        }

        public BigInteger Mantissa { get; internal set; }
        public int Exponent { get; internal set; }

        public int CompareTo(object obj)
        {
            if (ReferenceEquals(obj, null) || !(obj is BigDecimal))
                throw new ArgumentException();
            return CompareTo((BigDecimal) obj);
        }

        public int CompareTo(BigDecimal other)
        {
            return this < other ? -1 : (this > other ? 1 : 0);
        }

        public void NormaliseExponentBiggerThanZero()
        {
            if (Exponent > 0)
            {
                Mantissa = Mantissa.Multiply(BigInteger.ValueOf(10).Pow(Exponent));
                Exponent = 0;
            }
        }

        /// <summary>
        ///     Removes trailing zeros on the mantissa
        /// </summary>
        public void Normalize()
        {
            if (Exponent == 0) return;

            if (Mantissa.LongValue == 0)
            {
                Exponent = 0;
            }
            else
            {
                BigInteger remainder = BigInteger.Zero;
                while (remainder.LongValue == 0)
                {
                    BigInteger[] divideAndRemainder = Mantissa.DivideAndRemainder(BigInteger.ValueOf(10));
                    BigInteger shortened = divideAndRemainder[0];
                    remainder = divideAndRemainder[1];
                    if (remainder.LongValue != 0)
                        continue;
                    Mantissa = shortened;
                    Exponent++;
                }
                NormaliseExponentBiggerThanZero();
            }
        }

        /// <summary>
        ///     Truncate the number to the given precision by removing the least significant digits.
        /// </summary>
        /// <returns>The truncated number</returns>
        internal BigDecimal Truncate(int precision = Precision)
        {
            // copy this instance (remember its a struct)
            var shortened = this;
            // save some time because the number of digits is not needed to remove trailing zeros
            shortened.Normalize();
            // remove the least significant digits, as long as the number of digits is higher than the given Precision
            while (shortened.Mantissa.ToString().Length > precision)
            {
                shortened.Mantissa = shortened.Mantissa.Divide(BigInteger.Ten);
                shortened.Exponent++;
            }
            return shortened;
        }

        /// <summary>
        ///     Truncate the number, removing all decimal digits.
        /// </summary>
        /// <returns>The truncated number</returns>
        public BigDecimal Floor()
        {
            return Truncate(Mantissa.NumberOfDigits() + Exponent);
        }

        public override string ToString()
        {
            Normalize();
            var s = Mantissa.ToString();
            if (Exponent != 0)
            {
                var decimalPos = s.Length + Exponent;
                if (decimalPos < s.Length)
                    if (decimalPos >= 0)
                        s = s.Insert(decimalPos, decimalPos == 0 ? "0." : ".");
                    else
                        s = "0." + s.PadLeft(decimalPos * -1 + s.Length, '0');
                else
                    s = s.PadRight(decimalPos, '0');
            }
            return s;
        }

        public bool Equals(BigDecimal other)
        {
            var first = this;
            var second = other;
            first.Normalize();
            second.Normalize();
            return second.Mantissa.Equals(first.Mantissa) && second.Exponent == first.Exponent;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            return obj is BigDecimal && Equals((BigDecimal) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Mantissa.GetHashCode() * 397) ^ Exponent;
            }
        }

        #region Conversions

        public static implicit operator BigDecimal(int value)
        {
            return new BigDecimal(value);
        }

        public static implicit operator BigDecimal(double value)
        {
            var mantissa = BigInteger.ValueOf((long) value);
            var exponent = 0;
            double scaleFactor = 1;
            while (Math.Abs(value * scaleFactor - mantissa.LongValue) > 0)
            {
                exponent -= 1;
                scaleFactor *= 10;
                mantissa = BigInteger.ValueOf((long) (value * scaleFactor));
            }
            return new BigDecimal(mantissa, exponent);
        }

        public static implicit operator BigDecimal(decimal value)
        {
            var mantissa = new BigInteger(Decimal.Truncate(value).ToString(CultureInfo.InvariantCulture));
            var exponent = 0;
            decimal scaleFactor = 1;
            while (mantissa.ToDecimal() != value * scaleFactor)
            {
                exponent -= 1;
                scaleFactor *= 10;
                mantissa = new BigInteger(Decimal.Truncate(value * scaleFactor).ToString(CultureInfo.InvariantCulture));
            }
            return new BigDecimal(mantissa, exponent);
        }

        public static explicit operator double(BigDecimal value)
        {
            return double.Parse(value.ToString(), CultureInfo.InvariantCulture);
        }

        public static explicit operator float(BigDecimal value)
        {
            return float.Parse(value.ToString(), CultureInfo.InvariantCulture);
        }

        public static explicit operator decimal(BigDecimal value)
        {
            return decimal.Parse(value.ToString(), CultureInfo.InvariantCulture);
        }

        public static explicit operator int(BigDecimal value)
        {
            return Convert.ToInt32((decimal) value);
        }

        public static explicit operator uint(BigDecimal value)
        {
            return Convert.ToUInt32((decimal) value);
        }

        #endregion

        #region Operators

        public static BigDecimal operator +(BigDecimal value)
        {
            return value;
        }

        public static BigDecimal operator -(BigDecimal value)
        {
            value.Mantissa = value.Mantissa.Negate();
            return value;
        }

        public static BigDecimal operator ++(BigDecimal value)
        {
            return value + 1;
        }

        public static BigDecimal operator --(BigDecimal value)
        {
            return value - 1;
        }

        public static BigDecimal operator +(BigDecimal left, BigDecimal right)
        {
            return Add(left, right);
        }

        public static BigDecimal operator -(BigDecimal left, BigDecimal right)
        {
            return Add(left, -right);
        }

        private static BigDecimal Add(BigDecimal left, BigDecimal right)
        {
            return left.Exponent > right.Exponent
                ? new BigDecimal(AlignExponent(left, right).Add(right.Mantissa), right.Exponent)
                : new BigDecimal(AlignExponent(right, left).Add(left.Mantissa), left.Exponent);
        }

        public static BigDecimal operator *(BigDecimal left, BigDecimal right)
        {
            return new BigDecimal(left.Mantissa.Multiply(right.Mantissa), left.Exponent + right.Exponent);
        }

        public static BigDecimal operator /(BigDecimal dividend, BigDecimal divisor)
        {
            var exponentChange = Precision - (dividend.Mantissa.NumberOfDigits() - divisor.Mantissa.NumberOfDigits());
            if (exponentChange < 0)
                exponentChange = 0;
            dividend.Mantissa = dividend.Mantissa.Multiply(BigInteger.Ten.Pow(exponentChange));
            return new BigDecimal(dividend.Mantissa.Divide(divisor.Mantissa),
                dividend.Exponent - divisor.Exponent - exponentChange);
        }

        public static bool operator ==(BigDecimal left, BigDecimal right)
        {
            return left.Exponent == right.Exponent && left.Mantissa == right.Mantissa;
        }

        public static bool operator !=(BigDecimal left, BigDecimal right)
        {
            return left.Exponent != right.Exponent || left.Mantissa != right.Mantissa;
        }

        public static bool operator <(BigDecimal left, BigDecimal right)
        {
            return left.Exponent > right.Exponent
                ? AlignExponent(left, right).CompareTo(right.Mantissa) < 0
                : left.Mantissa.CompareTo(AlignExponent(right, left)) < 0;
        }

        public static bool operator >(BigDecimal left, BigDecimal right)
        {
            return left.Exponent > right.Exponent
                ? AlignExponent(left, right).CompareTo(right.Mantissa) > 0
                : left.Mantissa.CompareTo(AlignExponent(right, left)) > 0;
        }

        public static bool operator <=(BigDecimal left, BigDecimal right)
        {
            return left.Exponent > right.Exponent
                ? AlignExponent(left, right).CompareTo(right.Mantissa) <= 0
                : left.Mantissa.CompareTo(AlignExponent(right, left)) <= 0;
        }

        public static bool operator >=(BigDecimal left, BigDecimal right)
        {
            return left.Exponent > right.Exponent
                ? AlignExponent(left, right).CompareTo(right.Mantissa) >= 0
                : left.Mantissa.CompareTo(AlignExponent(right, left)) >= 0;
        }

        public static BigDecimal Parse(string value)
        {
            //todo culture format
            var decimalCharacter = ".";
            var indexOfDecimal = value.IndexOf(".");
            var exponent = 0;
            if (indexOfDecimal != -1)
                exponent = (value.Length - (indexOfDecimal + 1)) * -1;
            var mantissa = new BigInteger(value.Replace(decimalCharacter, ""));
            return new BigDecimal(mantissa, exponent);
        }

        /// <summary>
        ///     Returns the mantissa of value, aligned to the exponent of reference.
        ///     Assumes the exponent of value is larger than of value.
        /// </summary>
        private static BigInteger AlignExponent(BigDecimal value, BigDecimal reference)
        {
            return value.Mantissa.Multiply(BigInteger.Ten.Pow(value.Exponent - reference.Exponent));
        }

        #endregion

        #region Additional mathematical functions

        public static BigDecimal Exp(double exponent)
        {
            var tmp = (BigDecimal) 1;
            while (Math.Abs(exponent) > 100)
            {
                var diff = exponent > 0 ? 100 : -100;
                tmp *= Math.Exp(diff);
                exponent -= diff;
            }
            return tmp * Math.Exp(exponent);
        }

        public static BigDecimal Pow(double basis, double exponent)
        {
            var tmp = (BigDecimal) 1;
            while (Math.Abs(exponent) > 100)
            {
                var diff = exponent > 0 ? 100 : -100;
                tmp *= Math.Pow(basis, diff);
                exponent -= diff;
            }
            return tmp * Math.Pow(basis, exponent);
        }

        #endregion
    }
}