using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_Contains
    {
        static public bool ContainsAny(this string item, IEnumerable<string> sub_strings)
        {
            return sub_strings.Has(s => item.Contains(s));
        }
        static public bool ContainsAny(this string item, params string[] sub_strings)
        {
            return item.ContainsAny((IEnumerable<string>)sub_strings);
        }
    }
}