using System;
using System.Reflection;

namespace Crunchy.Dough
{
    public class StepStopwatch : TemporalSeries
    {
        private Stopwatch timer;
        private long elapsed_time_in_milliseconds;

        private long max_step_in_milliseconds;

        public StepStopwatch(long m, TimeSource t)
        {
            timer = new Stopwatch(t);
            elapsed_time_in_milliseconds = 0;

            max_step_in_milliseconds = m;
        }

        public StepStopwatch(Duration d, TimeSource t) : this(d.GetWholeMilliseconds(), t) { }

        public StepStopwatch(long m) : this(m, TimeSource_System.INSTANCE) { }
        public StepStopwatch(Duration d) : this(d.GetWholeMilliseconds()) { }

        public long Step()
        {
            long step_in_milliseconds = GetStepTimeInMilliseconds();

            elapsed_time_in_milliseconds += step_in_milliseconds;
            timer.Reset();

            return step_in_milliseconds;
        }

        public bool Start()
        {
            return timer.Start();
        }

        public bool Pause()
        {
            return timer.Pause();
        }

        public void SetSpeed(float s)
        {
            timer.SetSpeed(s);
        }

        public void SetTimeSource(TimeSource source)
        {
            timer.SetTimeSource(source);
        }

        public void SetElapsedTimeInMilliseconds(long m)
        {
            timer.Reset();
            elapsed_time_in_milliseconds = m;
        }

        public bool IsRunning()
        {
            return timer.IsRunning();
        }

        public long GetStepTimeInMilliseconds()
        {
            return timer.GetElapsedTimeInMilliseconds().BindBetween(0, max_step_in_milliseconds);
        }

        public long GetElapsedTimeInMilliseconds()
        {
            return elapsed_time_in_milliseconds + GetStepTimeInMilliseconds();
        }

        public float GetSpeed()
        {
            return timer.GetSpeed();
        }

        public TimeSource GetTimeSource()
        {
            return timer.GetTimeSource();
        }
    }
}