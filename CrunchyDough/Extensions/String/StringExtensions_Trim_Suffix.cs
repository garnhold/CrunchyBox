using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_Trim_Suffix
    {
        static public bool TryTrimSuffix(this string item, string suffix, out string output)
        {
            if (item != null)
            {
                if (item.EndsWith(suffix))
                {
                    output = item.TruncateAmount(suffix.GetLength());
                    return true;
                }
            }

            output = item;
            return false;
        }
        static public string TrimSuffix(this string item, string suffix)
        {
            item.TryTrimSuffix(suffix, out item);
            return item;
        }

        static public bool TryTrimAnySuffix(this string item, out string output, IEnumerable<string> suffixs)
        {
            string suffix;

            if (item.TryFindAnySuffix(out suffix, suffixs))
                return item.TryTrimSuffix(suffix, out output);

            output = item;
            return false;
        }
        static public bool TryTrimAnySuffix(this string item, out string output, params string[] suffixs)
        {
            return item.TryTrimAnySuffix(out output, (IEnumerable<string>)suffixs);
        }

        static public string TrimAnySuffix(this string item, IEnumerable<string> suffixs)
        {
            string output;

            item.TryTrimAnySuffix(out output, suffixs);
            return output;
        }
        static public string TrimAnySuffix(this string item, params string[] suffixs)
        {
            return item.TrimAnySuffix((IEnumerable<string>)suffixs);
        }
    }
}