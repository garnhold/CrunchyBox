using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public partial class TTCS
    {
        static public string Decorate(IEnumerable<string> items, string pre = "", string post = "", string seperator = ", ")
        {
            return items
                .PrependVisible(pre)
                .AppendVisible(post)
                .Join(seperator);
        }

        static public IEnumerable<int> GetNumbering(int number)
        {
            return Ints.Ray(1, 1, number);
        }

        static public IEnumerable<string> GetNumberedTerms(string base_name, int number)
        {
            return GetNumbering(number).Convert(delegate(int n) {
                if(base_name.Has("#"))
                    return base_name.Replace("#", n.ToString());

                return base_name;
            });
        }
        static public IEnumerable<string> GetEndlessNumberedTerms(string base_name)
        {
            return GetNumberedTerms(base_name, int.MaxValue);
        }
    }
}