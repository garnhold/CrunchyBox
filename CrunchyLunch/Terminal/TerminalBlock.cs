using System;

using CrunchyDough;

namespace CrunchyLunch
{
    public abstract class TerminalBlock
    {
        private int x;
        private int y;
        private int width;

        private RateLimiter refresh_limiter;

        private Terminal terminal;

        static private readonly long MIN_MILLISECONDS_BETWEEN_REFRESHES = 60;

        protected abstract void RenderInternal(int x, int y, int width, Terminal terminal);

        public TerminalBlock(int nw)
        {
            width = nw;

            refresh_limiter = new RateLimiter(MIN_MILLISECONDS_BETWEEN_REFRESHES);
        }

        public void Render()
        {
            if (terminal != null)
            {
                refresh_limiter.Process(delegate() {
                    terminal.Raster(x, y, width, " ".Repeat(width));
                    RenderInternal(x, y, width, terminal);
                });
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