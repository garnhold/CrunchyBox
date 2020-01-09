using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_Lines
    {
        static public int GetNumberLines(this string item)
        {
            if (item.IsVisible())
                return item.RegexMatches("(\r\n|\n|\\p{Zl}|\\p{Zp})").Count + 1;

            return 0;
        }

        static public IEnumerable<string> GetLines(this string item)
        {
            if (item != null)
                return item.RegexSplit("(\r\n|\n|\\p{Zl}|\\p{Zp})");

            return Empty.IEnumerable<string>();
        }

        static public bool IsMultiLine(this string item)
        {
            if (item.GetNumberLines() > 1)
                return true;

            return false;
        }

        static public bool IsSingleLine(this string item)
        {
            if (item.IsMultiLine() == false)
                return true;

            return false;
        }
    }
}