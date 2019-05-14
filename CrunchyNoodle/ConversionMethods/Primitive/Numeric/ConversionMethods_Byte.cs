using System;

using CrunchyDough;

namespace CrunchyNoodle
{
    [Conversion]
    static public class ConversionMethods_Byte
    {
        [Conversion]
        static public bool ToBool(byte input)
        {
            if (input == 0)
                return false;

            return true;
        }

        [Conversion]
        static public byte ToByte(byte input)
        {
            return input;
        }

        [Conversion]
        static public short ToShort(byte input)
        {
            return input;
        }

        [Conversion]
        static public int ToInt(byte input)
        {
            return input;
        }

        [Conversion]
        static public long ToLong(byte input)
        {
            return input;
        }

        [Conversion]
        static public float ToFloat(byte input)
        {
            return input;
        }

        [Conversion]
        static public double ToDouble(byte input)
        {
            return input;
        }

        [Conversion]
        static public decimal ToDecimal(byte input)
        {
            return input;
        }

        [Conversion]
        static public string ToString(byte input)
        {
            return input.ToString();
        }
    }
}