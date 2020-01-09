using System;

namespace Crunchy.Noodle
{
    using Dough;
    
    [Conversion]
    static public class GeneralConversionMethods_String
    {
        [Conversion]
        static public string ToString(object value, Type type)
        {
            return value.ToStringEX();
        }
    }
}