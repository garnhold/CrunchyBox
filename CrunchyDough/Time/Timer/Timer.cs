using System;

namespace CrunchyDough
{
    public class Timer : TemporalSeries
    {
        [StateField]private bool is_running;
        private long start_time_in_milliseconds;

        [StateField]private long accumulated_time_in_milliseconds;

        [SettingField]private TimeSource time_source;

        public Timer(TimeSource t)
        {
            time_source = t;
        }

        public Timer() : this(TimeSource_Stopwatch.INSTANCE) { }

        public bool Start()
        {
            if (is_running == false)
            {
                start_time_in_milliseconds = time_source.GetCurrentTimeInMilliseconds();

                is_running = true;
                return true;
            }

            return false;
        }

        public bool Pause()
        {
            if (is_running == true)
            {
                accumulated_time_in_milliseconds = GetElapsedTimeInMilliseconds();

                is_running = false;
                return true;
            }

            return false;
        }

        public void SetElapsedTimeInMilliseconds(long m)
        {
            start_time_in_milliseconds = time_source.GetCurrentTimeInMilliseconds();
            accumulated_time_in_milliseconds = m;
        }

        public bool IsRunning()
        {
            return is_running;
        }

        public long GetElapsedTimeInMilliseconds()
        {
            long elapsed_time = accumulated_time_in_milliseconds;

            if (is_running)
                elapsed_time += time_source.GetCurrentTimeInMilliseconds() - start_time_in_milliseconds;

            return elapsed_time;
        }

        public TimeSource GetTimeSource()
        {
            return time_source;
        }
    }
}