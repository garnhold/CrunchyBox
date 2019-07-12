using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_Count_Any
    {
        static public int CountAny(this string item, char[] characters, int maximum_count = int.MaxValue)
        {
            int index = 0;
            int count = 0;

            if (item != null)
            {
                while (item.TryFindIndexOfAny(out index, characters, index) && count < maximum_count)
                {
                    index++;
                    count++;
                }
            }

            return count;
        }

        static public bool IsCountAnyEqualTo(this string item, char[] characters, int number)
        {
            if (item.CountAny(characters, number + 1) == number)
                return true;

            return false;
        }

        static public bool IsCountAnyNotEqualTo(this string item, char[] characters, int number)
        {
            if (item.CountAny(characters, number + 1) != number)
                return true;

            return false;
        }

        static public bool IsCountAnyLessThanOrEqualTo(this string item, char[] characters, int number)
        {
            if (item.CountAny(characters, number + 1) <= number)
                return true;

            return false;
        }
        static public bool IsCountAnyLessThan(this string item, char[] characters, int number)
        {
            return item.IsCountAnyLessThanOrEqualTo(characters, number - 1);
        }

        static public bool IsCountAnyGreaterThanOrEqualTo(this string item, char[] characters, int number)
        {
            if (item.CountAny(characters, number) >= number)
                return true;

            return false;
        }
        static public bool IsCountAnyGreaterThan(this string item, char[] characters, int number)
        {
            return item.IsCountAnyGreaterThanOrEqualTo(characters, number + 1);
        }
    }
}