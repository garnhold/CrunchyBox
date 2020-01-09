using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_Intersection
    {
        static public int LengthOfIntersection(this string item, string input)
        {
            for (int i = Math.Max(0, item.GetLength() - input.GetLength()); i < item.GetLength(); i++)
            {
                int length_of_intersection = item.GetLength() - i;

                if (item.IsSubstring(i, 0, length_of_intersection, input))
                    return length_of_intersection;
            }

            return 0;
        }

        static public int IndexOfIntersectionStart(this string item, string input)
        {
            return item.GetLength() - item.LengthOfIntersection(input);
        }

        static public int IndexOfIntersectionEnd(this string item, string input)
        {
            return item.LengthOfIntersection(input);
        }
    }
}