using System;

namespace CrunchyDough
{
    public class Stopwatch : TemporalSeries
    {
        private bool is_running;
        private long start_time_in_milliseconds;

        private long accumulated_time_in_milliseconds;

        private float speed;
        private TimeSource time_source;

        private void ChangeParameter(Process process)
        {
            long elapsed_time = GetElapsedTimeInMilliseconds();

            process();
            SetElapsedTimeInMilliseconds(elapsed_time);
        }

        public Stopwatch(TimeSource t, float s)
        {
            speed = s;
            time_source = t;
        }

        public Stopwatch(TimeSource t) : this(t, 1.0f) { }
        public Stopwatch() : this(TimeSource_System.INSTANCE) { }

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

        public void SetSpeed(float s)
        {
            if (s != speed)
                ChangeParameter(() => speed = s);
        }

        public void SetTimeSource(TimeSource source)
        {
            if (source != time_source)
                ChangeParameter(() => time_source = source);
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
            if (is_running)
            {
                return (long)(
                    accumulated_time_in_milliseconds +
                    speed * (time_source.GetCurrentTimeInMilliseconds() - start_time_in_milliseconds)
                );
            }

            return accumulated_time_in_milliseconds;
        }

        public float GetSpeed()
        {
            return speed;
        }

        public TimeSource GetTimeSource()
        {
            return time_source;
        }
    }
}