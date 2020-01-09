using System;

namespace Crunchy.Noodle
{
    using Dough;
    
    [Conversion]
    static public class ConversionMethods_DateTime
    {
        [Conversion]
        static public DateTime ToDateTime(string input)
        {
            return input.ParseDateTime();
        }

        [Conversion]
        static public string ToString(DateTime input)
        {
            return input.ToString();
        }
    }
}