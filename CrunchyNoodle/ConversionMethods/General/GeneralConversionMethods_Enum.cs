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
    }
}