using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_Trim_Prefix
    {
        static public bool TryTrimPrefix(this string item, string prefix, out string output)
        {
            if (item != null)
            {
                if (item.StartsWith(prefix))
                {
                    output = item.SubSection(prefix.GetLength(), item.GetLength());
                    return true;
                }
            }

            output = item;
            return false;
        }
        static public string TrimPrefix(this string item, string prefix)
        {
            item.TryTrimPrefix(prefix, out item);
            return item;
        }

        static public bool TryTrimAnyPrefix(this string item, out string output, IEnumerable<string> prefixs)
        {
            string prefix;

            if (item.TryFindAnyPrefix(out prefix, prefixs))
                return item.TryTrimPrefix(prefix, out output);

            output = item;
            return false;
        }
        static public bool TryTrimAnyPrefix(this string item, out string output, params string[] prefixs)
        {
            return item.TryTrimAnyPrefix(out output, (IEnumerable<string>)prefixs);
        }

        static public string TrimAnyPrefix(this string item, IEnumerable<string> prefixs)
        {
            string output;

            item.TryTrimAnyPrefix(out output, prefixs);
            return output;
        }
        static public string TrimAnyPrefix(this string item, params string[] prefixs)
        {
            return item.TrimAnyPrefix((IEnumerable<string>)prefixs);
        }
    }
}