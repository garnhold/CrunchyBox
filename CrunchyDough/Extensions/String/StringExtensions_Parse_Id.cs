using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Crunchy.Dough
{
    static public class StringExtensions_Parse_Id
    {
        static public IEnumerable<string> ParseIds(this string item)
        {
            return item.RegexMatches("[A-Za-z_][A-Za-z0-9_]*")
                .Bridge<Match>()
                .Convert<Match, string>(m => m.Value);
        }
    }
}