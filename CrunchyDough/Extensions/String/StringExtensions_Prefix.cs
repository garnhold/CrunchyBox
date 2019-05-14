using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_Prefix
    {
        static public bool TryFindAnyPrefix(this string item, out string prefix, IEnumerable<string> prefixs)
        {
            return prefixs.TryFindFirst(s => item.StartsWith(s), out prefix);
        }
        static public bool TryFindAnyPrefix(this string item, out string prefix, params string[] prefixs)
        {
            return item.TryFindAnyPrefix(out prefix, (IEnumerable<string>)prefixs);
        }

        static public string FindAnyPrefix(this string item, IEnumerable<string> prefixs)
        {
            string prefix;

            item.TryFindAnyPrefix(out prefix, prefixs);
            return prefix;
        }
        static public string FindAnyPrefix(this string item, params string[] prefixs)
        {
            return item.FindAnyPrefix((IEnumerable<string>)prefixs);
        }
    }
}