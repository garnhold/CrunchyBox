using System;

namespace Crunchy.Noodle
{
    using Dough;
    
    [Conversion]
    static public class ConversionMethods_Duration
    {
        [Conversion]
        static public Duration ToDuration(string input)
        {
            return input.ParseDuration();
        }

        [Conversion]
        static public string ToString(Duration input)
        {
            return input.ToString();
        }
    }
}