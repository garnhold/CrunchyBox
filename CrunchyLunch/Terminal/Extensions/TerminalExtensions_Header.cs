using System;

using CrunchyDough;

namespace CrunchyLunch
{
    static public class TerminalExtensions_Header
    {
        static public TerminalBlock_Text_Padded WriteHeader(this Terminal item, string text)
        {
            return item.WritePaddedTextAndNewline(text, '-');
        }
    }
}