using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_Count
    {
        static public int Count(this string item, string sub_string, int maximum_count = int.MaxValue)
        {
            int index = 0;
            int count = 0;

            if (item != null)
            {
                while (item.TryFindIndexOf(out index, sub_string, index) && count < maximum_count)
                {
                    index += sub_string.Length;
                    count++;
                }
            }

            return count;
        }

        static public bool IsCountEqualTo(this string item, string sub_string, int number)
        {
            if (item.Count(sub_string, number + 1) == number)
                return true;

            return false;
        }

        static public bool IsCountNotEqualTo(this string item, string sub_string, int number)
        {
            if (item.Count(sub_string, number + 1) != number)
                return true;

            return false;
        }

        static public bool IsCountLessThanOrEqualTo(this string item, string sub_string, int number)
        {
            if (item.Count(sub_string, number + 1) <= number)
                return true;

            return false;
        }
        static public bool IsCountLessThan(this string item, string sub_string, int number)
        {
            return item.IsCountLessThanOrEqualTo(sub_string, number - 1);
        }

        static public bool IsCountGreaterThanOrEqualTo(this string item, string sub_string, int number)
        {
            if (item.Count(sub_string, number) >= number)
                return true;

            return false;
        }
        static public bool IsCountGreaterThan(this string item, string sub_string, int number)
        {
            return item.IsCountGreaterThanOrEqualTo(sub_string, number + 1);
        }
    }
}