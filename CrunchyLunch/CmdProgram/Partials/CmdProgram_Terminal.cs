using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyLunch
{
    public abstract partial class CmdProgram
    {
        public void PrintIndent()
        {
            GetTerminal().Indent();
        }
        public void PrintDedent()
        {
            GetTerminal().Dedent();
        }

        public void PrintNewline()
        {
            GetTerminal().Newline();
        }

        public TerminalBlock_Text PrintText(string text)
        {
            return GetTerminal().WriteText(text);
        }
        public TerminalBlock_Text PrintTextAndNewline(string text)
        {
            return GetTerminal().WriteTextAndNewline(text);
        }

        public TerminalBlock_Text_Padded PrintPaddedText(string text, int width, char padding)
        {
            return GetTerminal().WritePaddedText(text, width, padding);
        }
        public TerminalBlock_Text_Padded PrintPaddedTextAndNewline(string text, char padding)
        {
            return GetTerminal().WritePaddedTextAndNewline(text, padding);
        }
        public TerminalBlock_Text_Padded PrintHeader(string text)
        {
            return GetTerminal().WriteHeader(text);
        }

        public TerminalBlock_Progress PrintProgress(int bar_width)
        {
            return GetTerminal().WriteProgress(bar_width);
        }
        public TerminalBlock_Progress PrintProgressAndNewline()
        {
            return GetTerminal().WriteProgressAndNewline();
        }

        public Terminal GetTerminal()
        {
            return Terminal_Console.GetInstance();
        }
    }
}