using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public partial class TTCS
    {
        static public string Parameters(IEnumerable<string> type_names, string base_name, string pre = "", string post = "")
        {
            return Decorate(
                type_names.PairStrict(GetEndlessNumberedTerms(base_name), (s1, s2) => s1 + " " + s2),
                pre,
                post
            );
        }

        static public string Parameters(string type_name, string base_name, int number, string pre = "", string post = "")
        {
            return Parameters(GetNumberedTerms(type_name, number), base_name, pre, post);
        }
    }
}