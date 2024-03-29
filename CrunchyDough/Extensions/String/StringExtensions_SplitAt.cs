using System;

namespace Crunchy.Dough
{
    static public class StringExtensions_SplitAt
    {
        static public void SplitAtIndex(this string item, int index, out string first, out string second, int gap = 0)
        {
            first = item.SubSection(0, index);
            second = item.Offset(index + gap);
        }
        static public Tuple<string, string> SplitToTupleAtIndex(this string item, int index, int gap = 0)
        {
            string first;
            string second;

            item.SplitAtIndex(index, out first, out second, gap);
            return Tuple.New(first, second);
        }
        static public bool TrySplitAtIndex(this string item, int index, out string first, out string second, int gap = 0)
        {
            if (item.IsIndexValid(index))
            {
                item.SplitAtIndex(index, out first, out second, gap);
                return true;
            }

            first = "";
            second = "";
            return false;
        }

        static public void SplitAtIndexOf(this string item, string sub_string, out string first, out string second)
        {
            item.SplitAtIndex(item.FindIndexOf(sub_string), out first, out second, sub_string.GetLength());
        }
        static public Tuple<string, string> SplitToTupleAtIndexOf(this string item, string sub_string)
        {
            string first;
            string second;

            item.SplitAtIndexOf(sub_string, out first, out second);
            return Tuple.New(first, second);
        }
        static public bool TrySplitAtIndexOf(this string item, string sub_string, out string first, out string second)
        {
            int index;

            if (item.TryFindIndexOf(out index, sub_string))
                return item.TrySplitAtIndex(index, out first, out second, sub_string.GetLength());

            first = "";
            second = "";
            return false;
        }

        static public void SplitAtLastIndexOf(this string item, string sub_string, out string first, out string second)
        {
            item.SplitAtIndex(item.FindLastIndexOf(sub_string), out first, out second, sub_string.GetLength());
        }
        static public Tuple<string, string> SplitToTupleAtLastIndexOf(this string item, string sub_string)
        {
            string first;
            string second;

            item.SplitAtLastIndexOf(sub_string, out first, out second);
            return Tuple.New(first, second);
        }
        static public bool TrySplitAtLastIndexOf(this string item, string sub_string, out string first, out string second)
        {
            int index;

            if (item.TryFindLastIndexOf(out index, sub_string))
                return item.TrySplitAtIndex(index, out first, out second, sub_string.GetLength());

            first = "";
            second = "";
            return false;
        }
    }
}