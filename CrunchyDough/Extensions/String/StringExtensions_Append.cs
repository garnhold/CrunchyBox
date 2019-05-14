using System;

namespace CrunchyDough
{
    static public class StringExtensions_Append
    {
        static public string AppendIf(this string item, bool append, string to_add)
        {
            if (append)
                return item + to_add;

            return item;
        }

        static public string PrependIf(this string item, bool prepend, string to_add)
        {
            if (prepend)
                return to_add + item;

            return item;
        }

        static public string AppendToVisible(this string item, string to_add)
        {
            return item.AppendIf(item.IsVisible(), to_add);
        }

        static public string PrependToVisible(this string item, string to_add)
        {
            return item.PrependIf(item.IsVisible(), to_add);
        }
    }
}