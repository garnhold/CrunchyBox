using System;

namespace Crunchy.Noodle
{
    using Dough;
    
    [Conversion]
    static public class ConversionMethods_Decimal
    {
        [Conversion]
        static public bool ToBool(decimal input)
        {
            if (input == 0)
                return false;

            return true;
        }

        [Conversion]
        static public byte ToByte(decimal input)
        {
            if (input > byte.MaxValue)
                return byte.MaxValue;

            if (input < byte.MinValue)
                return byte.MinValue;

            return (byte)input;
        }

        [Conversion]
        static public short ToShort(decimal input)
        {
            if (input > short.MaxValue)
                return short.MaxValue;

            if (input < short.MinValue)
                return short.MinValue;

            return (short)input;
        }

        [Conversion]
        static public int ToInt(decimal input)
        {
            if (input > int.MaxValue)
                return int.MaxValue;

            if (input < int.MinValue)
                return int.MinValue;

            return (int)input;
        }

        [Conversion]
        static public long ToLong(decimal input)
        {
            if (input > long.MaxValue)
                return long.MaxValue;

            if (input < long.MinValue)
                return long.MinValue;

            return (long)input;
        }

        [Conversion]
        static public float ToFloat(decimal input)
        {
            return (float)input;
        }

        [Conversion]
        static public double ToDouble(decimal input)
        {
            return (double)input;
        }

        [Conversion]
        static public decimal ToDecimal(decimal input)
        {
            return input;
        }

        [Conversion]
        static public string ToString(decimal input)
        {
            return input.ToString();
        }
    }
}