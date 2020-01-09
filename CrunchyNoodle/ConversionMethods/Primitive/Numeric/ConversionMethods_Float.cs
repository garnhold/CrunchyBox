using System;

namespace Crunchy.Noodle
{
    using Dough;
    
    [Conversion]
    static public class ConversionMethods_Float
    {
        [Conversion]
        static public bool ToBool(float input)
        {
            if (input == 0)
                return false;

            return true;
        }

        [Conversion]
        static public byte ToByte(float input)
        {
            if (input > byte.MaxValue)
                return byte.MaxValue;

            if (input < byte.MinValue)
                return byte.MinValue;

            return (byte)input;
        }

        [Conversion]
        static public short ToShort(float input)
        {
            if (input > short.MaxValue)
                return short.MaxValue;

            if (input < short.MinValue)
                return short.MinValue;

            return (short)input;
        }

        [Conversion]
        static public int ToInt(float input)
        {
            if (input > int.MaxValue)
                return int.MaxValue;

            if (input < int.MinValue)
                return int.MinValue;

            return (int)input;
        }

        [Conversion]
        static public long ToLong(float input)
        {
            if (input > long.MaxValue)
                return long.MaxValue;

            if (input < long.MinValue)
                return long.MinValue;

            return (long)input;
        }

        [Conversion]
        static public float ToFloat(float input)
        {
            return input;
        }

        [Conversion]
        static public double ToDouble(float input)
        {
            return input;
        }

        [Conversion]
        static public decimal ToDecimal(float input)
        {
            if (input > (float)decimal.MaxValue)
                return decimal.MaxValue;

            if (input < (float)decimal.MinValue)
                return decimal.MinValue;

            return (decimal)input;
        }

        [Conversion]
        static public string ToString(float input)
        {
            return input.ToString();
        }
    }
}