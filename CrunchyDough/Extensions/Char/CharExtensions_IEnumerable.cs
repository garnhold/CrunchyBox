using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class CharExtensions_IEnumerable
    {
        static public string BuildString(this IEnumerable<char> item)
        {
            StringBuilder builder = new StringBuilder();

            foreach (char sub_item in item)
                builder.Append(sub_item);

            return builder.ToString();
        }
    }
}