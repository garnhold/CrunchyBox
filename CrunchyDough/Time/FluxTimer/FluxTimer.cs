using System;
using System.Reflection;

namespace CrunchyDough
{
    public class FluxTimer : TimePiece
    {
        private Timer timer;
        private float multiplier;

        private long elapsed_time_in_milliseconds;

        protected long GetInternalElapsedTimeInMilliseconds()
        {
            return (long)(timer.GetElapsedTimeInMilliseconds() * multiplier);
        }

        public FluxTimer(TimeSource t)
        {
            timer = new Timer(t);
            multiplier = 1.0f;

            elapsed_time_in_milliseconds = 0;
        }

        public FluxTimer() : this(TimeSource_Stopwatch.INSTANCE) { }

        public void SetMultiplier(float m)
        {
            elapsed_time_in_milliseconds += GetInternalElapsedTimeInMilliseconds();
            timer.Reset();

            multiplier = m;
        }

        public override bool Start()
        {
            return timer.Start();
        }

        public override bool Pause()
        {
            return timer.Pause();
        }

        public override void SetElapsedTimeInMilliseconds(long m)
        {
            timer.Reset();
            elapsed_time_in_milliseconds = m;
        }

        public override bool IsRunning()
        {
            return timer.IsRunning();
        }

        public float GetMultiplier()
        {
            return multiplier;
        }

        public override long GetElapsedTimeInMilliseconds()
        {
            return elapsed_time_in_milliseconds + GetInternalElapsedTimeInMilliseconds();
        }
    }
}