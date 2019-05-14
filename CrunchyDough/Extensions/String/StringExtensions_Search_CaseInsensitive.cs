using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_Search_CaseInsensitive
    {
        static public bool TryFindIndexOfCaseInsensitive(this string item, out int index, string needle) { return item.TryFindIndexOfCaseInsensitive(out index, needle, 0); }
        static public bool TryFindIndexOfCaseInsensitive(this string item, out int index, string needle, int start_index)
        {
            return item.ToLower().TryFindIndexOf(out index, needle.ToLower(), start_index);
        }
        static public int FindIndexOfCaseInsensitive(this string item, string needle) { return item.FindIndexOfCaseInsensitive(needle, 0); }
        static public int FindIndexOfCaseInsensitive(this string item, string needle, int start_index)
        {
            int index;

            item.TryFindIndexOfCaseInsensitive(out index, needle, start_index);
            return index;
        }

        static public bool TryFindLastIndexOfCaseInsensitive(this string item, out int index, string needle) { return item.TryFindLastIndexOfCaseInsensitive(out index, needle, item.GetFinalIndex()); }
        static public bool TryFindLastIndexOfCaseInsensitive(this string item, out int index, string needle, int start_index)
        {
            return item.ToLower().TryFindLastIndexOf(out index, needle.ToLower(), start_index);
        }
        static public int FindLastIndexOfCaseInsensitive(this string item, string needle) { return item.FindLastIndexOfCaseInsensitive(needle, item.GetFinalIndex()); }
        static public int FindLastIndexOfCaseInsensitive(this string item, string needle, int start_index)
        {
            int index;

            item.TryFindLastIndexOfCaseInsensitive(out index, needle, start_index);
            return index;
        }
    }
}