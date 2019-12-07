using System;

namespace Crunchy.Noodle
{
    using Dough;
    
    [Conversion]
    static public class ConversionMethods_Bool
    {
        [Conversion]
        static public bool ToBool(bool input)
        {
            return input;
        }

        [Conversion]
        static public byte ToByte(bool input)
        {
            return input.ConvertBool<byte>(1, 0);
        }

        [Conversion]
        static public short ToShort(bool input)
        {
            return input.ConvertBool<short>(1, 0);
        }

        [Conversion]
        static public int ToInt(bool input)
        {
            return input.ConvertBool<int>(1, 0);
        }

        [Conversion]
        static public long ToLong(bool input)
        {
            return input.ConvertBool<long>(1, 0);
        }

        [Conversion]
        static public float ToFloat(bool input)
        {
            return input.ConvertBool<float>(1.0f, 0.0f);
        }

        [Conversion]
        static public double ToDouble(bool input)
        {
            return input.ConvertBool<double>(1.0, 0.0);
        }

        [Conversion]
        static public decimal ToDecimal(bool input)
        {
            return input.ConvertBool<decimal>(1.0m, 0.0m);
        }

        [Conversion]
        static public string ToString(bool input)
        {
            return input.ToString();
        }
    }
}