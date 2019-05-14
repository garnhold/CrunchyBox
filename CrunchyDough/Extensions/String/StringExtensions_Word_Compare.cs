using System;

namespace CrunchyDough
{
    static public class StringExtensions_Word_Compare
    {
        static public bool AreWordsEqual(this string item, string to_check)
        {
            if (item.StyleAsWord().EqualsEX(to_check.StyleAsWord()))
                return true;

            return false;
        }

        static public bool AreWordInvariantsEqual(this string item, string to_check)
        {
            if (item.StyleAsWordInvariant().EqualsEX(to_check.StyleAsWordInvariant()))
                return true;

            return false;
        }
    }
}