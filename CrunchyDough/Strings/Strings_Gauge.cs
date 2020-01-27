using System;
using System.Text;

namespace Crunchy.Dough
{
    static public partial class Strings
    {
        static public string Gauge(float percent, int length, string start_cap, string end_cap, char full, char empty)
        {
            int full_length = (int)(percent.BindPercent() * length);
            int empty_length = length - full_length;

            return start_cap + full.Repeat(full_length) + empty.Repeat(empty_length) + end_cap;
        }

        static public string Gauge(float low, float high, float value, int length, string start_cap, string end_cap, char full, char empty)
        {
            float width = high - low;
            float offset = value - low;

            return Gauge(offset / width, length, start_cap, end_cap, full, empty);
        }
    }
}