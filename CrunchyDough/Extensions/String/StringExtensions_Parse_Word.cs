using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Crunchy.Dough
{
    static public class StringExtensions_Parse_Word
    {
        static public IEnumerable<string> ParseWords(this string item)
        {
            return item.RegexMatches("([A-Z]?[a-z0-9]+|[A-Z0-9]+(?![a-z]))")
                .Bridge<Match>()
                .Convert<Match, string>(m => m.Value.StyleAsWord());
        }

        static public IEnumerable<string> ParseWordInvariants(this string item)
        {
            return item.ParseWords().Convert<string, string>(s => s.StyleAsWordInvariant());
        }
    }
}