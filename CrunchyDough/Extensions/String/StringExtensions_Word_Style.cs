using System;

namespace Crunchy.Dough
{
    static public class StringExtensions_Word_Style
    {
        static public string StyleAsWord(this string item)
        {
            return item.RegexRemove("[^A-Za-z0-9_'-]");
        }

        static public string StyleAsWordInvariant(this string item)
        {
            return item.StyleAsWord().ToLower();
        }

        static public string StyleAsSingularWord(this string item)
        {
            return item.StyleAsWord().RegexRemove("((?<=s)es$|s$)");
        }

        static public string StyleAsPluralWord(this string item)
        {
            return item.StyleAsSingularWord().RegexReplace("s$", "se") + "s";
        }
    }
}