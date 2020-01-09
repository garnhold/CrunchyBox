using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_Regex_Convert
    {
        static public IEnumerable<T> RegexConvert<T>(this string item, Regex regex, Operation<T, string, Match> operation)
        {
            return item.RegexPeruse(regex).Convert(p => operation(p.item1, p.item2));
        }
        static public IEnumerable<T> RegexConvert<T>(this string item, string pattern, Operation<T, string, Match> operation)
        {
            return item.RegexConvert<T>(pattern.GetRegexByPattern(), operation);
        }

        static public IEnumerable<T> RegexConvert<T>(this string item, Regex regex, Operation<T, string> non_match_operation, Operation<T, Match> match_operation)
        {
            foreach (Tuple<string, Match> pair in item.RegexPeruse(regex))
            {
                if (pair.item1.IsNotEmpty())
                    yield return non_match_operation(pair.item1);

                if (pair.item2.IsNotNull())
                    yield return match_operation(pair.item2);
            }
        }
        static public IEnumerable<T> RegexConvert<T>(this string item, string pattern, Operation<T, string> non_match_operation, Operation<T, Match> match_operation)
        {
            return item.RegexConvert<T>(pattern.GetRegexByPattern(), non_match_operation, match_operation);
        }
    }
}