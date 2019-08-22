using System;
using System.Reflection;

namespace CrunchyDough
{
    public class StepTimer : TemporalSeries
    {
        private Timer timer;
        private long elapsed_time_in_milliseconds;

        private long max_step_in_milliseconds;

        public StepTimer(long m, TimeSource t)
        {
            timer = new Timer(t);
            elapsed_time_in_milliseconds = 0;

            max_step_in_milliseconds = m;
        }

        public StepTimer(Duration d, TimeSource t) : this(d.GetWholeMilliseconds(), t) { }

        public StepTimer(long m) : this(m, TimeSource_Stopwatch.INSTANCE) { }
        public StepTimer(Duration d) : this(d.GetWholeMilliseconds()) { }

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
    }
}