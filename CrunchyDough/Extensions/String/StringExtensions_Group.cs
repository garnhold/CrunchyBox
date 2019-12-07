using System;

using System.Text.RegularExpressions;

namespace Crunchy.Dough
{
    static public class StringExtensions_Group
    {
        static public string RemoveGroup(this string item, Group to_remove)
        {
            return item.RemoveSub(to_remove.Index, to_remove.Length);
        }

        static public string ExtractGroup(this string item, Group to_remove, out string capture)
        {
            capture = to_remove.Value;

            return item.RemoveGroup(to_remove);
        }
    }
}