using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class LazySchedule<T>
    {
        private long frame_target_time;

        private Stopwatch frame_timer;
        private Schedule<T> schedule;

        public LazySchedule(long f, long e, Process<T> p, TimeSource t)
        {
            frame_target_time = f;

            frame_timer = new Stopwatch(t).StartAndGet();
            schedule = new Schedule<T>(e, p, t);
        }

        public LazySchedule(long f, Process<T> p, TimeSource t) : this(f, 2000, p, t) { }

        public LazySchedule(long f, long e, Process<T> p) : this(f, e, p, TimeSource_System.INSTANCE) { }
        public LazySchedule(long f, Process<T> p) : this(f, p, TimeSource_System.INSTANCE) { }

        public LazySchedule(Duration f, Duration e, Process<T> p, TimeSource t) : this(f.GetWholeMilliseconds(), e.GetWholeMilliseconds(), p, t) { }
        public LazySchedule(Duration f, Process<T> p, TimeSource t) : this(f.GetWholeMilliseconds(), p, t) { }

        public LazySchedule(Duration f, Duration e, Process<T> p) : this(f, e, p, TimeSource_System.INSTANCE) { }
        public LazySchedule(Duration f, Process<T> p) : this(f, p, TimeSource_System.INSTANCE) { }

        public void Work()
        {
            long remaining_time = frame_target_time - frame_timer.GetElapsedTimeInMilliseconds();

            schedule.Work(remaining_time.BindAbove(1));
            frame_timer.Restart();
        }

        public void AddAt(long timestamp, T data)
        {
            schedule.AddAt(timestamp, data);
        }

        public void AddIn(long delay, T data)
        {
            schedule.AddIn(delay, data);
        }
    }
}