using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_Combine
    {
        static public string CombineBreakEarly(this string item, string input, string break_string = "")
        {
            return item.ExtractPreIntersection(input) + break_string + input;
        }

        static public string CombineBreakLate(this string item, string input, string break_string = "")
        {
            return item + break_string + item.ExtractPostIntersection(input);
        }
    }
}