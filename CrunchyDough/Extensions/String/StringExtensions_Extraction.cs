using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_Extraction
    {
        static public string SubSection(this string item, int start, int end)
        {
            if (item.PullSubSectionValid(ref start, ref end))
                return item.Substring(start, end - start);

            return "";
        }

        static public string Sub(this string item, int start, int length)
        {
            return item.SubSection(start, start + length);
        }

        static public string Offset(this string item, int start)
        {
            return item.SubSection(start, item.Length);
        }

        static public string Truncate(this string item, int end)
        {
            return item.SubSection(0, end);
        }

        static public string OffsetBefore(this string item, string input)
        {
            return item.Offset(item.IndexOf(input));
        }

        static public string OffsetAfter(this string item, string input)
        {
            return item.Offset(item.IndexOf(input) + input.GetLength());
        }

        static public string TruncateBefore(this string item, string input)
        {
            return item.Truncate(item.IndexOf(input));
        }

        static public string TruncateAfter(this string item, string input)
        {
            return item.Truncate(item.IndexOf(input) + input.GetLength());
        }

        static public string TruncateAmount(this string item, int amount)
        {
            return item.Truncate(item.Length - amount);
        }

        static public string ExtractPreIntersection(this string item, string input)
        {
            return item.Truncate(item.IndexOfIntersectionStart(input));
        }

        static public string ExtractPostIntersection(this string item, string input)
        {
            return input.Offset(item.IndexOfIntersectionEnd(input));
        }
    }
}