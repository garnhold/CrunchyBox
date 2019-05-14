using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_Search_Regex
    {
        static public bool TryFindIndexOfRegex(this string item, out int index, Regex pattern) { return item.TryFindIndexOfRegex(out index, pattern, 0); }
        static public bool TryFindIndexOfRegex(this string item, out int index, Regex pattern, int start_index)
        {
            Match match = item.RegexMatch(pattern, start_index);

            if (match.Success)
            {
                index = match.Index;
                return true;
            }

            index = item.Length;
            return false;
        }
        static public bool TryFindIndexOfRegex(this string item, out int index, string pattern) { return item.TryFindIndexOfRegex(out index, pattern, 0); }
        static public bool TryFindIndexOfRegex(this string item, out int index, string pattern, int start_index)
        {
            return item.TryFindIndexOfRegex(out index, pattern.GetRegexByPattern(), start_index);
        }

        static public int FindIndexOfRegex(this string item, Regex pattern) { return item.FindIndexOfRegex(pattern, 0); }
        static public int FindIndexOfRegex(this string item, Regex pattern, int start_index)
        {
            int index;

            item.TryFindIndexOfRegex(out index, pattern, start_index);
            return index;
        }
        static public int FindIndexOfRegex(this string item, string pattern) { return item.FindIndexOfRegex(pattern, 0); }
        static public int FindIndexOfRegex(this string item, string pattern, int start_index)
        {
            return item.FindIndexOfRegex(pattern.GetRegexByPattern(), start_index);
        }

        static public bool TryFindLastIndexOfRegex(this string item, out int index, string pattern) { return item.TryFindLastIndexOfRegex(out index, pattern, item.GetFinalIndex()); }
        static public bool TryFindLastIndexOfRegex(this string item, out int index, string pattern, int start_index)
        {
            Match match = item.ReverseRegexMatch(pattern, start_index);

            if (match.Success)
            {
                index = match.Index;
                return true;
            }

            index = -1;
            return false;
        }

        static public int FindLastIndexOfRegex(this string item, string pattern) { return item.FindLastIndexOfRegex(pattern, item.GetFinalIndex()); }
        static public int FindLastIndexOfRegex(this string item, string pattern, int start_index)
        {
            int index;

            item.TryFindLastIndexOfRegex(out index, pattern, start_index);
            return index;
        }
    }
}