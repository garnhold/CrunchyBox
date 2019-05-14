using System;

using CrunchyDough;

namespace CrunchyLunch
{
    public class TerminalBlock_Gauge : TerminalBlock
    {
        private float value;
        private float lower_value;
        private float upper_value;

        private int bar_width;

        protected override void RenderInternal(int x, int y, int width, Terminal terminal)
        {
            terminal.Raster(x, y, width, Strings.Gauge(lower_value, upper_value, value, bar_width, "[", "]", '=', ' '));
        }

        public TerminalBlock_Gauge(float l, float u, int bw) : base(bw + 3)
        {
            lower_value = l;
            upper_value = u;

            bar_width = bw;
        }

        public TerminalBlock_Gauge(float l, float u) : this(l, u, 0) { }

        public void SetValue(float v)
        {
            value = v;

            Render();
        }

        public void SetLowerValue(float v)
        {
            lower_value = v;

            Render();
        }

        public void SetUpperValue(float v)
        {
            upper_value = v;

            Render();
        }

        public float GetValue()
        {
            return value;
        }

        public float GetLowerValue()
        {
            return lower_value;
        }

        public float GetUpperValue()
        {
            return upper_value;
        }
    }
}