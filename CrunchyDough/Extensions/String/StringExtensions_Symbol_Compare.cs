using System;

namespace Crunchy.Dough
{
    static public class StringExtensions_Symbol_Compare
    {
        static public bool AreSymbolsEqual(this string item, string to_check)
        {
            if (item.StyleAsSymbol().EqualsEX(to_check.StyleAsSymbol()))
                return true;

            return false;
        }

        static public bool AreSymbolInvariantsEqual(this string item, string to_check)
        {
            if (item.StyleAsSymbolInvariant().EqualsEX(to_check.StyleAsSymbolInvariant()))
                return true;

            return false;
        }
    }
}