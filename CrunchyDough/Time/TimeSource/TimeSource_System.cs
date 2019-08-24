using System;
using System.Diagnostics;

namespace CrunchyDough
{
    public class TimeSource_System : TimeSource
    {
        private System.Diagnostics.Stopwatch system_stopwatch;

        static public readonly TimeSource INSTANCE = new TimeSource_System();

        private TimeSource_System()
        {
            system_stopwatch = new System.Diagnostics.Stopwatch();
            system_stopwatch.Start();
        }

        public override long GetCurrentTimeInMilliseconds()
        {
            return system_stopwatch.ElapsedMilliseconds;
        }
    }
}