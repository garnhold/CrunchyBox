using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_Regex_Consume
    {
        static public void RegexConsume(this string item, Regex regex, Process<string, Match> process)
        {
            item.RegexPeruse(regex).Process(p => process(p.item1, p.item2));
        }
        static public void RegexConsume(this string item, string pattern, Process<string, Match> process)
        {
            item.RegexConsume(pattern.GetRegexByPattern(), process);
        }

        static public void RegexConsume(this string item, Regex regex, Process<string> non_match_process, Process<Match> match_process)
        {
            item.RegexConsume(regex, delegate(string non_match, Match match) {
                if (non_match.IsNotEmpty())
                    non_match_process(non_match);

                if (match.IsNotNull())
                    match_process(match);
            });
        }
        static public void RegexConsume(this string item, string pattern, Process<string> non_match_process, Process<Match> match_process)
        {
            item.RegexConsume(pattern.GetRegexByPattern(), non_match_process, match_process);
        }
    }
}