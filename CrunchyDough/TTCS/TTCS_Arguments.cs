using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public partial class TTCS
    {
        static public string Arguments(string base_name, int number, string pre = "", string post = "")
        {
            return Decorate(GetNumberedTerms(base_name, number), pre, post);
        }

        static public string ArgumentsForGeneric(string base_name, int number, string pre = "", string post = "")
        {
            return Arguments(base_name, number, pre, post).SurroundVisible("<", ">");
        }

        static public string ArgumentsForGeneric(string name, bool enable, string pre = "", string post = "")
        {
            return Decorate(
                enable.ConvertBool(Enumerable.New(name), Empty.IEnumerable<string>()),
                pre,
                post
            ).SurroundVisible("<", ">");
        }
    }
}