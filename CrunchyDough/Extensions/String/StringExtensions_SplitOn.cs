using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_SplitOn
    {
        static public IEnumerable<string> SplitOn(this string item, params string[] seperators)
        {
            return item.Split(seperators, StringSplitOptions.None);
        }

        static public void SplitOnPartOut(this string item, out string output1, params string[] seperators)
        {
            item.SplitOn(seperators).PartOut(out output1);
        }
        static public void SplitOnPartOut(this string item, out string output1, out string output2, params string[] seperators)
        {
            item.SplitOn(seperators).PartOut(out output1, out output2);
        }
        static public void SplitOnPartOut(this string item, out string output1, out string output2, out string output3, params string[] seperators)
        {
            item.SplitOn(seperators).PartOut(out output1, out output2, out output3);
        }
        static public void SplitOnPartOut(this string item, out string output1, out string output2, out string output3, out string output4, params string[] seperators)
        {
            item.SplitOn(seperators).PartOut(out output1, out output2, out output3, out output4);
        }

        static public Tuple<string, string, string> SplitToTupleOn3(this string item, params string[] seperators)
        {
            string output1;
            string output2;
            string output3;

            item.SplitOnPartOut(out output1, out output2, out output3, seperators);
            return Tuple.New(output1, output2, output3);
        }
        static public Tuple<string, string, string, string> SplitToTupleOn4(this string item, params string[] seperators)
        {
            string output1;
            string output2;
            string output3;
            string output4;

            item.SplitOnPartOut(out output1, out output2, out output3, out output4, seperators);
            return Tuple.New(output1, output2, output3, output4);
        }
    }
}