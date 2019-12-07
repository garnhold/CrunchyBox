using System;

namespace Crunchy.Dough
{
    static public class StringExtensions_Space
    {
        public const int DEFAULT_NUMBER_SPACES_PER_TAB = 4;

        static public int FindIndexOfPreviousIsland(this string item, int start_index)
        {
            return item.FindLastIndexOfAny(CharExtensions_Category.LINEAR_WHITESPACE, start_index) + 1;
        }
        static public int FindIndexOfFirstIsland(this string item)
        {
            return item.FindIndexOfPreviousIsland(0);
        }
        static public int FindIndexOfLastIsland(this string item)
        {
            return item.FindIndexOfPreviousIsland(item.GetFinalIndex());
        }

        static public int CalculateNumberSpaces(this string item, int spaces_per_tab = DEFAULT_NUMBER_SPACES_PER_TAB)
        {
            return item.Count(" ") + item.Count("\t") * spaces_per_tab;
        }

        static public int CalculateNumberTabs(this string item, int spaces_per_tab = DEFAULT_NUMBER_SPACES_PER_TAB)
        {
            return item.CalculateNumberSpaces(spaces_per_tab) / spaces_per_tab;
        }
    }
}