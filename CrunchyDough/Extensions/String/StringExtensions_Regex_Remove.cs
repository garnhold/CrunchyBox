using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Crunchy.Dough
{
    static public class StringExtensions_Regex_Remove
    {
        static public string RegexRemove(this string item, Regex pattern)
        {
            return item.RegexReplace(pattern, "");
        }
        static public string RegexRemove(this string item, string pattern)
        {
            return item.RegexRemove(pattern.GetRegexByPattern());
        }
        static public string RegexRemove(this string item, CachedRegex pattern)
        {
            return item.RegexReplace(pattern, "");
        }
    }
}