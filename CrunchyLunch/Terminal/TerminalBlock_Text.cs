using System;

namespace Crunchy.Lunch
{
    using Dough;
    
    public class TerminalBlock_Text : TerminalBlock
    {
        private string text;

        protected override void RenderInternal(int x, int y, int width, Terminal terminal)
        {
            terminal.Raster(x, y, width, text);
        }

        public TerminalBlock_Text(string t, int w) : base(w)
        {
            text = t;
        }

        public TerminalBlock_Text(int w) : this("", w) { }
        public TerminalBlock_Text(string t) : this(t, t.Length) { }
        public TerminalBlock_Text() : this("") { }

        public void SetText(string t)
        {
            text = t;

            Render();
        }

        public string GetText()
        {
            return text;
        }
    }
}