using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_Remove
    {
        static public string RemoveSub(this string item, int index, int length)
        {
            if(item.IsSubValid(index, length))
                return item.Remove(index, length);

            return item;
        }

        static public string RemoveSubSection(this string item, int start, int end)
        {
            return item.RemoveSub(start, end - start);
        }

        static public string RemoveFirst(this string item, string to_remove)
        {
            return item.ReplaceFirst(to_remove, "");
        }

        static public string Remove(this string item, string to_remove)
        {
            return item.Replace(to_remove, "");
        }

        static public string RemoveFirstCaseInsensitive(this string item, string to_remove)
        {
            return item.ReplaceFirstCaseInsensitive(to_remove, "");
        }

        static public string RemoveCaseInsensitive(this string item, string to_remove)
        {
            return item.ReplaceCaseInsensitive(to_remove, "");
        }
    }
}