using System;
using System.Reflection;

namespace CrunchyDough
{
    public class StepTimer : TimePiece
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

        public long GetStepTimeInMilliseconds()
        {
            return timer.GetElapsedTimeInMilliseconds().BindBetween(0, max_step_in_milliseconds);
        }

        public override long GetElapsedTimeInMilliseconds()
        {
            return elapsed_time_in_milliseconds + GetStepTimeInMilliseconds();
        }
    }
}