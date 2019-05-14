using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class Schedule<T>
    {
        private Timer schedule_timer;
        private Scheduler<T> scheduler;

        public Schedule(long e, Process<T> p, TimeSource t)
        {
            schedule_timer = new Timer(t).StartAndGet();
            scheduler = new Scheduler<T>(e, p, t);
        }

        public Schedule(long e, Process<T> p) : this(e, p, TimeSource_Stopwatch.INSTANCE) { }
        public Schedule(Process<T> p, TimeSource t) : this(0, p, t) { }

        public Schedule(Duration e, Process<T> p, TimeSource t) : this(e.GetWholeMilliseconds(), p, t) { }
        public Schedule(Duration e, Process<T> p) : this(e, p, TimeSource_Stopwatch.INSTANCE) { }

        public Schedule(Process<T> p) : this(p, TimeSource_Stopwatch.INSTANCE) { }

        public void Work(long target_work_milliseconds)
        {
            scheduler.Work(GetScheduleTimestamp(), target_work_milliseconds);
        }

        public void AddAt(long timestamp, T data)
        {
            scheduler.Add(timestamp, data);
        }

        public void AddIn(long delay, T data)
        {
            AddAt(GetScheduleTimestamp() + delay, data);
        }

        public long GetScheduleTimestamp()
        {
            return schedule_timer.GetElapsedTimeInMilliseconds();
        }
    }
}