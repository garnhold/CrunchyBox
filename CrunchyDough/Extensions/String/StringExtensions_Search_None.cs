using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_Search_None
    {
        static public int IndexOfNone(this string item, char[] characters, int start_index)
        {
            for (int i = start_index.BindAbove(0); i < item.Length; i++)
            {
                if (characters.Has(item[i]) == false)
                    return i;
            }

            return -1;
        }
        static public int LastIndexOfNone(this string item, char[] characters, int start_index)
        {
            for (int i = start_index.BindBelow(item.GetFinalIndex()); i >= 0; i--)
            {
                if (characters.Has(item[i]) == false)
                    return i;
            }

            return -1;
        }

        static public bool TryFindIndexOfNone(this string item, out int index, char[] characters) { return item.TryFindIndexOfNone(out index, characters, 0); }
        static public bool TryFindIndexOfNone(this string item, out int index, char[] characters, int start_index)
        {
            int return_value = item.IndexOfNone(characters, start_index);

            if (return_value != -1)
            {
                index = return_value;
                return true;
            }

            index = item.Length;
            return false;
        }

        static public int FindIndexOfNone(this string item, char[] characters) { return item.FindIndexOfNone(characters, 0); }
        static public int FindIndexOfNone(this string item, char[] characters, int start_index)
        {
            int index;

            item.TryFindIndexOfNone(out index, characters, start_index);
            return index;
        }

        static public bool TryFindLastIndexOfNone(this string item, out int index, char[] characters) { return item.TryFindLastIndexOfNone(out index, characters, item.GetFinalIndex()); }
        static public bool TryFindLastIndexOfNone(this string item, out int index, char[] characters, int start_index)
        {
            int return_value = item.LastIndexOfNone(characters, start_index);

            if (return_value != -1)
            {
                index = return_value;
                return true;
            }

            index = -1;
            return false;
        }

        static public int FindLastIndexOfNone(this string item, char[] characters) { return item.FindLastIndexOfNone(characters, item.GetFinalIndex()); }
        static public int FindLastIndexOfNone(this string item, char[] characters, int start_index)
        {
            int index;

            item.TryFindLastIndexOfNone(out index, characters, start_index);
            return index;
        }
    }
}