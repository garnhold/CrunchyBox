using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_StartsWith
    {
        static public bool StartsWithAny(this string item, IEnumerable<string> prefixs)
        {
            return prefixs.Has(p => item.StartsWith(p));
        }
        static public bool StartsWithAny(this string item, params string[] prefixs)
        {
            return item.StartsWithAny((IEnumerable<string>)prefixs);
        }
    }
}