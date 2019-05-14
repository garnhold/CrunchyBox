using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_Search_Any
    {
        static public bool HasAny(this string item, char[] characters)
        {
            int index;

            return item.TryFindIndexOfAny(out index, characters);
        }

        static public bool TryFindIndexOfAny(this string item, out int index, char[] characters) { return item.TryFindIndexOfAny(out index, characters, 0); }
        static public bool TryFindIndexOfAny(this string item, out int index, char[] characters, int start_index)
        {
            int return_value = item.IndexOfAny(characters, start_index.BindBetween(0, item.GetFinalIndex()));

            if (return_value != -1)
            {
                index = return_value;
                return true;
            }

            index = item.Length;
            return false;
        }

        static public int FindIndexOfAny(this string item, char[] characters) { return item.FindIndexOfAny(characters, 0); }
        static public int FindIndexOfAny(this string item, char[] characters, int start_index)
        {
            int index;

            item.TryFindIndexOfAny(out index, characters, start_index);
            return index;
        }

        static public bool TryFindLastIndexOfAny(this string item, out int index, char[] characters) { return item.TryFindLastIndexOfAny(out index, characters, item.GetFinalIndex()); }
        static public bool TryFindLastIndexOfAny(this string item, out int index, char[] characters, int start_index)
        {
            int return_value = item.LastIndexOfAny(characters, start_index.BindBetween(0, item.GetFinalIndex()));

            if (return_value != -1)
            {
                index = return_value;
                return true;
            }

            index = -1;
            return false;
        }

        static public int FindLastIndexOfAny(this string item, char[] characters) { return item.FindLastIndexOfAny(characters, item.GetFinalIndex()); }
        static public int FindLastIndexOfAny(this string item, char[] characters, int start_index)
        {
            int index;

            item.TryFindLastIndexOfAny(out index, characters, start_index);
            return index;
        }
    }
}