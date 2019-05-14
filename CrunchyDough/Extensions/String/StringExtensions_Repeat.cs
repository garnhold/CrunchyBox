using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_Repeat
    {
        static public string Repeat(this string item, int iterations)
        {
            if (iterations > 0)
            {
                StringBuilder string_builder = new StringBuilder(item.GetLength() * iterations);

                for (int i = 0; i < iterations; i++)
                    string_builder.Append(item);

                return string_builder.ToString();
            }

            return "";
        }
    }
}