using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_EndsWith
    {
        static public bool EndsWithAny(this string item, IEnumerable<string> suffixs)
        {
            return suffixs.Has(p => item.EndsWith(p));
        }
        static public bool EndsWithAny(this string item, params string[] suffixs)
        {
            return item.EndsWithAny((IEnumerable<string>)suffixs);
        }
    }
}