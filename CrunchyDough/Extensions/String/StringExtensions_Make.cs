using System;

namespace Crunchy.Dough
{
    static public class StringExtensions_Make
    {
        static public string MakeSingleLine(this string item)
        {
            return item.RegexRemove("[\r\n]");
        }

        static public string MakeSingleIsland(this string item)
        {
            return item.RegexRemove("[ \t\r\n]");
        }
    }
}