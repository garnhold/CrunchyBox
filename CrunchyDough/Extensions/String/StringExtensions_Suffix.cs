using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_Suffix
    {
        static public bool TryFindAnySuffix(this string item, out string suffix, IEnumerable<string> suffixs)
        {
            return suffixs.TryFindFirst(s => item.EndsWith(s), out suffix);
        }
        static public bool TryFindAnySuffix(this string item, out string suffix, params string[] suffixs)
        {
            return item.TryFindAnySuffix(out suffix, (IEnumerable<string>)suffixs);
        }

        static public string FindAnySuffix(this string item, IEnumerable<string> suffixs)
        {
            string suffix;

            item.TryFindAnySuffix(out suffix, suffixs);
            return suffix;
        }
        static public string FindAnySuffix(this string item, params string[] suffixs)
        {
            return item.FindAnySuffix((IEnumerable<string>)suffixs);
        }
    }
}