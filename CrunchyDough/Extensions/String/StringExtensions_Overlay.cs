using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_Overlay
    {
        static public string Overlay(this string item, string input, Operation<char, char, char> operation)
        {
            return item.PairPermissive(input).Convert(p => operation(p.item1, p.item2)).BuildString();
        }

        static public string Overlay(this string item, string input, Operation<int, char> operation)
        {
            return item.Overlay(input, (c1, c2) => (operation(c1) > operation(c2)).ConvertBool(c1, c2));
        }

        static public string Overlay(this string item, string input, Operation<bool, char> operation)
        {
            return item.Overlay(input, c => operation(c).ConvertBool(1, 0));
        }

        static public string Overlay(this string item, string input, char background)
        {
            return item.Overlay(input, c => c != background);
        }

        static public string Overlay(this string item, string input, IEnumerable<char> background)
        {
            return item.Overlay(input, c => background.AreNone(c));
        }

        static public string Overlay(this string item, string input)
        {
            return item.Overlay(input, CharExtensions_Category.WHITESPACE);
        }
    }
}