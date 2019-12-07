using System;

namespace Crunchy.Lunch
{
    using Dough;
    
    static public class TerminalExtensions_Header
    {
        static public TerminalBlock_Text_Padded WriteHeader(this Terminal item, string text)
        {
            return item.WritePaddedTextAndNewline(text, '-');
        }
    }
}