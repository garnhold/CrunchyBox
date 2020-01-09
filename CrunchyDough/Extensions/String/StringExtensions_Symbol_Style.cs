using System;

namespace Crunchy.Dough
{
    static public class StringExtensions_Symbol_Style
    {
        static public string StyleAsSymbol(this string item)
        {
            return item.RegexRemove("[ \t\r\n]+");
        }

        static public string StyleAsSymbolInvariant(this string item)
        {
            return item.StyleAsSymbol().ToLower();
        }
    }
}