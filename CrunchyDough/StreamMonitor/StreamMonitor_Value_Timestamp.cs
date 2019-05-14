using System;
using System.IO;

namespace CrunchyDough
{
    public class StreamMonitor_Value_Timestamp : StreamMonitor_Value<DateTime>
    {
        protected override DateTime GetCurrentValue()
        {
            return GetStreamSystemStream().GetTimestamp();
        }

        public StreamMonitor_Value_Timestamp(StreamSystemStream s) : base(s, DateTime.MinValue) { }
    }
}