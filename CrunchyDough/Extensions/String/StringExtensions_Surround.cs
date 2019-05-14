using System;

namespace CrunchyDough
{
    static public class StringExtensions_Surround
    {
        static public string Surround(this string item, string prefix, string suffix)
        {
            return prefix + item + suffix;
        }
        static public string SurroundVisible(this string item, string prefix, string suffix)
        {
            if (item.IsVisible())
                return item.Surround(prefix, suffix);

            return item;
        }

        static public string Surround(this string item, string prefix_suffix)
        {
            return item.Surround(prefix_suffix, prefix_suffix);
        }
        static public string SurroundVisible(this string item, string prefix_suffix)
        {
            if (item.IsVisible())
                return item.Surround(prefix_suffix);

            return item;
        }
    }
}