using System;

namespace Crunchy.Dough
{
    static public class StringExtensions_Ensured
    {
        static public string EnsuredPrefix(this string item, string prefix)
        {
            if (item.StartsWith(prefix))
                return item;

            return prefix + item;
        }

        static public string EnsuredSuffix(this string item, string suffix)
        {
            if (item.EndsWith(suffix))
                return item;

            return item + suffix;
        }
    }
}