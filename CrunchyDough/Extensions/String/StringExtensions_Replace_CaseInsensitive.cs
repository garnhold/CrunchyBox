using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_Replace_CaseInsensitive
    {
        static public string ReplaceFirstCaseInsensitive(this string item, string to_replace, string replacement)
        {
            int index;

            if (item.TryFindIndexOfCaseInsensitive(out index, to_replace))
                return item.RemoveSubAndInsert(index, to_replace.Length, replacement);

            return item;
        }

        static public string ReplaceCaseInsensitive(this string item, string to_replace, string replacement)
        {
            int index = 0;

            while (item.TryFindIndexOfCaseInsensitive(out index, to_replace, index))
            {
                item = item.RemoveSubAndInsert(index, to_replace.Length, replacement);
                index += replacement.Length;
            }

            return item;
        }
    }
}