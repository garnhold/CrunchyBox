using System;

using CrunchyDough;

namespace CrunchyNoodle
{
    [Conversion]
    static public class GeneralConversionMethods_Enum
    {
        [Conversion]
        static public Enum ToEnum(string value, Type type)
        {
            return value.ParseEnum(type);
        }

        [Conversion]
        static public Enum ToEnum(byte value, Type type)
        {
            return type.GetEnumValueByLongValue(value);
        }

        [Conversion]
        static public Enum ToEnum(short value, Type type)
        {
            return type.GetEnumValueByLongValue(value);
        }

        [Conversion]
        static public Enum ToEnum(int value, Type type)
        {
            return type.GetEnumValueByLongValue(value);
        }

        [Conversion]
        static public Enum ToEnum(long value, Type type)
        {
            return type.GetEnumValueByLongValue(value);
        }
    }
}