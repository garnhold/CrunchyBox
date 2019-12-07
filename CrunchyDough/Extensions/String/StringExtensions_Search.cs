using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_Search
    {
        static public bool Has(this string item, string needle)
        {
            int index;

            return item.TryFindIndexOf(out index, needle);
        }

        static public bool TryFindIndexOf(this string item, out int index, string needle) { return item.TryFindIndexOf(out index, needle, 0); }
        static public bool TryFindIndexOf(this string item, out int index, string needle, int start_index)
        {
            int return_value = item.IndexOf(needle, start_index);

            if (return_value != -1)
            {
                index = return_value;
                return true;
            }

            index = item.Length;
            return false;
        }
        static public int FindIndexOf(this string item, string needle) { return item.FindIndexOf(needle, 0); }
        static public int FindIndexOf(this string item, string needle, int start_index)
        {
            int index;

            item.TryFindIndexOf(out index, needle, start_index);
            return index;
        }

        static public bool TryFindLastIndexOf(this string item, out int index, string needle) { return item.TryFindLastIndexOf(out index, needle, item.GetFinalIndex()); }
        static public bool TryFindLastIndexOf(this string item, out int index, string needle, int start_index)
        {
            int return_value = item.LastIndexOf(needle, start_index);

            if (return_value != -1)
            {
                index = return_value;
                return true;
            }

            index = -1;
            return false;
        }
        static public int FindLastIndexOf(this string item, string needle) { return item.FindLastIndexOf(needle, item.GetFinalIndex()); }
        static public int FindLastIndexOf(this string item, string needle, int start_index)
        {
            int index;

            item.TryFindLastIndexOf(out index, needle, start_index);
            return index;
        }
    }
}