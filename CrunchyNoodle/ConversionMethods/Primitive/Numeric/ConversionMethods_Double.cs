using System;

using CrunchyDough;

namespace CrunchyNoodle
{
    [Conversion]
    static public class ConversionMethods_Double
    {
        [Conversion]
        static public bool ToBool(double input)
        {
            if (input == 0)
                return false;

            return true;
        }

        [Conversion]
        static public byte ToByte(double input)
        {
            if (input > byte.MaxValue)
                return byte.MaxValue;

            if (input < byte.MinValue)
                return byte.MinValue;

            return (byte)input;
        }

        [Conversion]
        static public short ToShort(double input)
        {
            if (input > short.MaxValue)
                return short.MaxValue;

            if (input < short.MinValue)
                return short.MinValue;

            return (short)input;
        }

        [Conversion]
        static public int ToInt(double input)
        {
            if (input > int.MaxValue)
                return int.MaxValue;

            if (input < int.MinValue)
                return int.MinValue;

            return (int)input;
        }

        [Conversion]
        static public long ToLong(double input)
        {
            if (input > long.MaxValue)
                return long.MaxValue;

            if (input < long.MinValue)
                return long.MinValue;

            return (long)input;
        }

        [Conversion]
        static public float ToFloat(double input)
        {
            if (input > float.MaxValue)
                return float.MaxValue;

            if (input < float.MinValue)
                return float.MinValue;

            return (float)input;
        }

        [Conversion]
        static public double ToDouble(double input)
        {
            return input;
        }

        [Conversion]
        static public decimal ToDecimal(double input)
        {
            if (input > (double)decimal.MaxValue)
                return decimal.MaxValue;

            if (input < (double)decimal.MinValue)
                return decimal.MinValue;

            return (decimal)input;
        }

        [Conversion]
        static public string ToString(double input)
        {
            return input.ToString();
        }
    }
}