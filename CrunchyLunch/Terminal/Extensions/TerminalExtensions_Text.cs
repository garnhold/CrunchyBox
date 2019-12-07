using System;

namespace Crunchy.Lunch
{
    using Dough;
    
    static public class TerminalExtensions_Text
    {
        static public TerminalBlock_Text WriteText(this Terminal item, string text)
        {
            return item.AppendTerminalBlock(new TerminalBlock_Text(text));
        }
        static public TerminalBlock_Text WriteTextAndNewline(this Terminal item, string text)
        {
            return item.AppendTerminalBlockNewline(new TerminalBlock_Text(text));
        }

        static public TerminalBlock_Text_Padded WritePaddedText(this Terminal item, string text, int width, char padding)
        {
            return item.AppendTerminalBlock(new TerminalBlock_Text_Padded(text, width, padding));
        }
        static public TerminalBlock_Text_Padded WritePaddedTextAndNewline(this Terminal item, string text, char padding)
        {
            return item.AppendTerminalBlockNewline(new TerminalBlock_Text_Padded(text, padding));
        }
    }
}