using System;
using System.Diagnostics;

namespace CrunchyDough
{
    public class TimeSource_Stopwatch : TimeSource
    {
        private Stopwatch stopwatch;

        static public readonly TimeSource INSTANCE = new TimeSource_Stopwatch();

        private TimeSource_Stopwatch()
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();
        }

        public override long GetCurrentTimeInMilliseconds()
        {
            return stopwatch.ElapsedMilliseconds;
        }
    }
}