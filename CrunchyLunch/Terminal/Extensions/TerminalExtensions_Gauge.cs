using System;

namespace Crunchy.Lunch
{
    using Dough;
    
    static public class TerminalExtensions_Gauge
    {
        static public TerminalBlock_Gauge WriteGauge(this Terminal item, float lower, float upper, int bar_width)
        {
            return item.AppendTerminalBlock(new TerminalBlock_Gauge(lower, upper, bar_width));
        }
        static public TerminalBlock_Gauge WriteGaugeAndNewline(this Terminal item, float lower, float upper)
        {
            return item.AppendTerminalBlockNewline(new TerminalBlock_Gauge(lower, upper));
        }
    }
}