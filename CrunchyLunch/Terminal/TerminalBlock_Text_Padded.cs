using System;

namespace Crunchy.Lunch
{
    using Dough;
    
    public class TerminalBlock_Text_Padded : TerminalBlock_Text
    {
        private char padding;

        protected override void RenderInternal(int x, int y, int width, Terminal terminal)
        {
            int remaining_width = width - GetText().Length;
            int half_remaining_width1 = remaining_width / 2;
            int half_remaining_width2 = remaining_width - half_remaining_width1;

            terminal.Raster(x, y, width, padding.Repeat(half_remaining_width1) + GetText() + padding.Repeat(half_remaining_width2));
        }

        public TerminalBlock_Text_Padded(string t, int w, char p) : base(t, w)
        {
            padding = p;
        }
        public TerminalBlock_Text_Padded(string t, char p) : this(t, 0, p) { }
        public TerminalBlock_Text_Padded(string t, int w) : this(t, w, '-') { }
        public TerminalBlock_Text_Padded(string t) : this(t, t.Length) { }
        public TerminalBlock_Text_Padded() : this("") { }

        public void SetPadding(char p)
        {
            padding = p;

            Render();
        }

        public char GetPadding()
        {
            return padding;
        }
    }
}