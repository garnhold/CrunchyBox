using System;

namespace Crunchy.Noodle
{
    using Dough;
    
    [Conversion]
    static public class ConversionMethods_Long
    {
        [Conversion]
        static public bool ToBool(long input)
        {
            if (input == 0)
                return false;

            return true;
        }

        [Conversion]
        static public byte ToByte(long input)
        {
            if (input > byte.MaxValue)
                return byte.MaxValue;

            if (input < byte.MinValue)
                return byte.MinValue;

            return (byte)input;
        }

        [Conversion]
        static public short ToShort(long input)
        {
            if (input > short.MaxValue)
                return short.MaxValue;

            if (input < short.MinValue)
                return short.MinValue;

            return (short)input;
        }

        [Conversion]
        static public int ToInt(long input)
        {
            if (input > int.MaxValue)
                return int.MaxValue;

            if (input < int.MinValue)
                return int.MinValue;

            return (int)input;
        }

        [Conversion]
        static public long ToLong(long input)
        {
            return input;
        }

        [Conversion]
        static public float ToFloat(long input)
        {
            return input;
        }

        [Conversion]
        static public double ToDouble(long input)
        {
            return input;
        }

        [Conversion]
        static public decimal ToDecimal(long input)
        {
            return input;
        }

        [Conversion]
        static public string ToString(long input)
        {
            return input.ToString();
        }
    }
}