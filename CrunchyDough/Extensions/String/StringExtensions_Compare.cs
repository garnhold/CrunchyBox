using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_Compare
    {
        static public bool IsNotEmpty(this string item)
        {
            if (item != null)
            {
                if (item.Length > 0)
                    return true;
            }

            return false;
        }

        static public bool IsEmpty(this string item)
        {
            if (item.IsNotEmpty() == false)
                return true;

            return false;
        }

        static public bool IsVisible(this string item)
        {
            if (item.IsBlank() == false)
                return true;

            return false;
        }

        static public bool IsBlank(this string item)
        {
            if (item == null || item.RegexIsMatch("^[\\s\\p{C}]*$"))
                return true;

            return false;
        }

        static public bool IsId(this string item)
        {
            if (item.RegexIsMatch("^[A-Za-z_][A-Za-z0-9_]*$"))
                return true;

            return false;
        }

        static public bool IsSubstring(this string item, int dst_start, int src_start, int length, string substring)
        {
            int dst_end = dst_start + length;
            int src_end = src_start + length;

            if (item.IsSubSectionValid(dst_start, dst_end) && substring.IsSubSectionValid(src_start, src_end))
            {
                for (int i = 0; i < length; i++)
                {
                    if (item[dst_start + i] != substring[src_start + i])
                        return false;
                }

                return true;
            }

            return false;
        }

        static public bool HasTrailingWhitespace(this string item)
        {
            if (item.RegexIsMatch("\\s$"))
                return true;

            return false;
        }
    }
}