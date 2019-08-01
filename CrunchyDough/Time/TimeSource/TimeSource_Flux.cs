using System;
using System.Diagnostics;

namespace CrunchyDough
{
    public class TimeSource_Flux : TimeSource
    {
        private Timer timer;
        private float multiplier;

        private long milliseconds;

        private long CalculateRunningMilliseconds()
        {
            return (long)(timer.GetElapsedTimeInMilliseconds() * multiplier);
        }

        public TimeSource_Flux(TimeSource t)
        {
            timer = new Timer(t).StartAndGet();
            multiplier = 1.0f;

            milliseconds = 0;
        }

        public TimeSource_Flux() : this(TimeSource_Stopwatch.INSTANCE) { }

        public void SetMultiplier(float m)
        {
            milliseconds += CalculateRunningMilliseconds();
            timer.Reset();

            multiplier = m;
        }

        public float GetMultiplier()
        {
            return multiplier;
        }

        public void Resume()
        {
            timer.Start();
        }

        public void Suspend()
        {
            timer.Pause();
        }

        public override long GetCurrentTimeInMilliseconds()
        {
            return milliseconds + CalculateRunningMilliseconds();
        }
    }
}