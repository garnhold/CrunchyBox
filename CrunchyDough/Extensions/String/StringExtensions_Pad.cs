using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_Pad
    {
        static public string PadLeftAndRight(this string item, int target_length, string left, string right)
        {
            int remainder = target_length - item.GetLength();
            int left_length = remainder / 2;
            int right_length = remainder - left_length;

            return left.RepeatToExactLength(left_length) + item + right.RepeatToExactLength(right_length);
        }
        static public string PadLeftAndRight(this string item, int target_length, string padding)
        {
            return item.PadLeftAndRight(target_length, padding, padding);
        }
    }
}