using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_Trim_PrefixAndSuffix
    {
        static public bool TryTrimPrefixAndSuffix(this string item, string prefix, string suffix, out string output)
        {
            if (item != null)
            {
                if (item.StartsWith(prefix) && item.EndsWith(suffix))
                {
                    output = item.SubSection(prefix.GetLength(), item.GetLength() - suffix.GetLength());
                    return true;
                }
            }

            output = item;
            return false;
        }
        static public string TrimPrefixAndSuffix(this string item, string prefix, string suffix)
        {
            item.TryTrimPrefixAndSuffix(prefix, suffix, out item);
            return item;
        }

        static public bool TryTrimPrefixAndSuffix(this string item, string affix, out string output)
        {
            return item.TryTrimPrefixAndSuffix(affix, affix, out output);
        }
        static public string TrimPrefixAndSuffix(this string item, string affix)
        {
            item.TryTrimPrefixAndSuffix(affix, out item);
            return item;
        }
    }
}