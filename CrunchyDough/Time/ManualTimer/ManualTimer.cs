using System;
using System.Reflection;

namespace CrunchyDough
{
    public class ManualTimer : TemporalSeries
    {
        private bool is_running;
        private long elapsed_time_in_milliseconds;

        public void StepByMilliseconds(long milliseconds)
        {
            if (is_running)
                elapsed_time_in_milliseconds += milliseconds;
        }

        public bool Start()
        {
            if (is_running == false)
            {
                is_running = true;
                return true;
            }

            return false;
        }

        public bool Pause()
        {
            if (is_running)
            {
                is_running = false;
                return true;
            }

            return false;
        }

        public void SetElapsedTimeInMilliseconds(long m)
        {
            elapsed_time_in_milliseconds = m;
        }

        public bool IsRunning()
        {
            return is_running;
        }

        public long GetElapsedTimeInMilliseconds()
        {
            return elapsed_time_in_milliseconds;
        }
    }
}