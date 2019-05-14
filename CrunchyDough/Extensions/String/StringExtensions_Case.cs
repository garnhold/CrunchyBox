using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_Case
    {
        static public IEnumerable<bool> GetCase(this string item)
        {
            return item.Convert(c => c.IsUppercase());
        }

        static public string ReplaceCase(this string item, IEnumerable<bool> upper_case)
        {
            return new string(item.PairPermissive(upper_case).Convert(p => p.item1.ReplaceCase(p.item2)).ToArray());
        }

        static public string ReplaceCaseToMatch(this string item, string to_match)
        {
            return item.ReplaceCase(to_match.GetCase());
        }
    }
}