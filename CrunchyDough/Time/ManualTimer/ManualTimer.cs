using System;
using System.Reflection;

namespace CrunchyDough
{
    public class ManualTimer : TimePiece
    {
        private bool is_running;
        private long elapsed_time_in_milliseconds;

        public void StepByMilliseconds(long milliseconds)
        {
            if (is_running)
                elapsed_time_in_milliseconds += milliseconds;
        }

        public override bool Start()
        {
            if (is_running == false)
            {
                is_running = true;
                return true;
            }

            return false;
        }

        public override bool Pause()
        {
            if (is_running)
            {
                is_running = false;
                return true;
            }

            return false;
        }

        public override void SetElapsedTimeInMilliseconds(long m)
        {
            elapsed_time_in_milliseconds = m;
        }

        public override bool IsRunning()
        {
            return is_running;
        }

        public override long GetElapsedTimeInMilliseconds()
        {
            return elapsed_time_in_milliseconds;
        }
    }
}