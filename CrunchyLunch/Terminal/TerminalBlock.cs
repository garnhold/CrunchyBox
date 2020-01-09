using System;

namespace Crunchy.Lunch
{
    using Dough;
    
    public abstract class TerminalBlock
    {
        private int x;
        private int y;
        private int width;

        private Timer refresh_timer;

        private Terminal terminal;

        static private readonly long MIN_MILLISECONDS_BETWEEN_REFRESHES = 60;

        protected abstract void RenderInternal(int x, int y, int width, Terminal terminal);

        public TerminalBlock(int nw)
        {
            width = nw;

            refresh_timer = new Timer(MIN_MILLISECONDS_BETWEEN_REFRESHES);
        }

        public void Render()
        {
            if (terminal != null)
            {
                if (refresh_timer.Repeat())
                {
                    terminal.Raster(x, y, width, " ".Repeat(width));
                    RenderInternal(x, y, width, terminal);
                }
            }
        }

        public void Place(int nx, int ny, Terminal nt)
        {
            x = nx;
            y = ny;
            terminal = nt;

            Render();
        }

        public void SetWidth(int w)
        {
            width = w;

            Render();
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public int GetWidth()
        {
            return width;
        }
    }
}