using System;

using CrunchyDough;

namespace CrunchyNoodle
{
    [Conversion]
    static public class ConversionMethods_Short
    {
        [Conversion]
        static public bool ToBool(short input)
        {
            if (input == 0)
                return false;

            return true;
        }

        [Conversion]
        static public byte ToByte(short input)
        {
            if (input > byte.MaxValue)
                return byte.MaxValue;

            if (input < byte.MinValue)
                return byte.MinValue;

            return (byte)input;
        }

        [Conversion]
        static public short ToShort(short input)
        {
            return input;
        }

        [Conversion]
        static public int ToInt(short input)
        {
            return input;
        }

        [Conversion]
        static public long ToLong(short input)
        {
            return input;
        }

        [Conversion]
        static public float ToFloat(short input)
        {
            return input;
        }

        [Conversion]
        static public double ToDouble(short input)
        {
            return input;
        }

        [Conversion]
        static public decimal ToDecimal(short input)
        {
            return input;
        }

        [Conversion]
        static public string ToString(short input)
        {
            return input.ToString();
        }
    }
}