using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_Regex_Peruse
    {
        static public IEnumerable<Tuple<string, Match>> RegexPeruse(this string item, Regex regex)
        {
            int index = 0;

            foreach (Match match in regex.Matches(item))
            {
                yield return new Tuple<string, Match>(item.SubSection(index, match.Index), match);
                index = match.Index + match.Length;
            }

            if (index < item.Length)
                yield return new Tuple<string, Match>(item.SubSection(index, item.Length), null);
        }
        static public IEnumerable<Tuple<string, Match>> RegexPeruse(this string item, string pattern)
        {
            return item.RegexPeruse(pattern.GetRegexByPattern());
        }
    }
}