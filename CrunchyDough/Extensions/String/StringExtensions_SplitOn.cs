using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_SplitOn
    {
        static public IEnumerable<string> SplitOn(this string item, params string[] seperators)
        {
            return item.Split(seperators, StringSplitOptions.None);
        }
    }
}