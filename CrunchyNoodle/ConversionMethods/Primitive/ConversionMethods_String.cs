using System;

namespace Crunchy.Noodle
{
    using Dough;
    
    [Conversion]
    static public class ConversionMethods_String
    {
        [Conversion]
        static public bool ToBool(string input)
        {
            return input.ParseBool();
        }

        [Conversion]
        static public byte ToByte(string input)
        {
            return input.ParseByte();
        }

        [Conversion]
        static public short ToShort(string input)
        {
            return input.ParseShort();
        }

        [Conversion]
        static public int ToInt(string input)
        {
            return input.ParseInt();
        }

        [Conversion]
        static public long ToLong(string input)
        {
            return input.ParseLong();
        }

        [Conversion]
        static public float ToFloat(string input)
        {
            return input.ParseFloat();
        }

        [Conversion]
        static public double ToDouble(string input)
        {
            return input.ParseDouble();
        }

        [Conversion]
        static public decimal ToDecimal(string input)
        {
            return input.ParseDecimal();
        }

        [Conversion]
        static public string ToString(string input)
        {
            return input;
        }
    }
}