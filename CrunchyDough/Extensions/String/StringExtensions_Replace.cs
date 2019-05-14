using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_Replace
    {
        static public string RemoveSubAndInsert(this string item, int index, int length, string replacement)
        {
            if(item.IsSubValid(index, length))
                return item.Remove(index, length).Insert(index, replacement);

            return item;
        }
        static public string RemoveSubSectionAndInsert(this string item, int start, int end, string replacement)
        {
            return item.RemoveSubAndInsert(start, end - start, replacement);
        }

        static public string ReplaceFirst(this string item, string to_replace, string replacement)
        {
            int index;

            if(item.TryFindIndexOf(out index, to_replace))
                return item.RemoveSubAndInsert(index, to_replace.Length, replacement);

            return item;
        }
    }
}