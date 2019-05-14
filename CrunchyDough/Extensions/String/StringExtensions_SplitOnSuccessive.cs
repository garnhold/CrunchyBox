using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_SplitOnSuccessive
    {
        static public IEnumerable<string> SplitOnSuccessive(this string item, string seperator)
        {
            StringBuilder builder = new StringBuilder();

            foreach (string chunk in item.SplitOn(seperator))
            {
                builder.Append(chunk);
                yield return builder.ToString();

                builder.Append(seperator);
            }
        }
    }
}