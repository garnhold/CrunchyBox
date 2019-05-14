using System;

using CrunchyDough;

namespace CrunchyNoodle
{
    [Conversion]
    static public class ConversionMethods_Int
    {
        [Conversion]
        static public bool ToBool(int input)
        {
            if (input == 0)
                return false;

            return true;
        }

        [Conversion]
        static public byte ToByte(int input)
        {
            if (input > byte.MaxValue)
                return byte.MaxValue;

            if (input < byte.MinValue)
                return byte.MinValue;

            return (byte)input;
        }

        [Conversion]
        static public short ToShort(int input)
        {
            if (input > short.MaxValue)
                return short.MaxValue;

            if (input < short.MinValue)
                return short.MinValue;

            return (short)input;
        }

        [Conversion]
        static public int ToInt(int input)
        {
            return input;
        }

        [Conversion]
        static public long ToLong(int input)
        {
            return input;
        }

        [Conversion]
        static public float ToFloat(int input)
        {
            return input;
        }

        [Conversion]
        static public double ToDouble(int input)
        {
            return input;
        }

        [Conversion]
        static public decimal ToDecimal(int input)
        {
            return input;
        }

        [Conversion]
        static public string ToString(int input)
        {
            return input.ToString();
        }
    }
}