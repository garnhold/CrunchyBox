using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_CompareTo
    {
        static public int NaturalCompareTo(this string item, string other)
        {
            string pattern = "([0-9]+)|([^0-9]+)";

            return item.RegexMatches(pattern).Bridge<Match>()
                .PairPermissive(other.RegexMatches(pattern).Bridge<Match>(),
                    delegate (Match match1, Match match2) {
                        if (match1 == null)
                            return -1;

                        if (match2 == null)
                            return 1;
                            
                        if (match1.Groups[1].Success)
                        {
                            if (match2.Groups[1].Success)
                            {
                                return match1.Value.PadLeft(match2.Length, '0').CompareTo(
                                    match2.Value.PadLeft(match1.Length, '0')
                                );
                            }
                            else
                            {
                                return -1;
                            }
                        }
                        else
                        {
                            if (match2.Groups[1].Success)
                            {
                                return 1;
                            }
                            else
                            {
                                return match1.Value.CompareTo(
                                    match2.Value
                                );
                            }
                        }
                    }
                )
                .FindFirst(i => i != 0);
        }
    }
}