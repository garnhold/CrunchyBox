using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class Scheduler<T>
    {
        private long allowable_earliness;
        private DynamicOrderList<SchedulerItem<T>> items;

        private Process<T> process;

        private Timer_Duration work_timer;

        public Scheduler(long e, Process<T> p, TimeSource t)
        {
            allowable_earliness = e;

            items = new DynamicOrderList<SchedulerItem<T>>(
                (i1, i2) => (int)(i1.GetTimestamp() - i2.GetTimestamp())
            );

            process = p;

            work_timer = new Timer_Duration(t);
        }

        public Scheduler(Duration e, Process<T> p, TimeSource t) : this(e.GetWholeMilliseconds(), p, t) { }
        public Scheduler(Duration e, Process<T> p) : this(e, p, TimeSource_Stopwatch.INSTANCE) { }

        public Scheduler(Process<T> p, TimeSource t) : this(0, p, t) { }
        public Scheduler(Process<T> p) : this(p, TimeSource_Stopwatch.INSTANCE) { }

        public void Work(long timestamp, long target_work_milliseconds)
        {
            long earliest_timestamp = timestamp;
            long latest_timestamp = timestamp + allowable_earliness;

            work_timer.RestartSetDurationInMilliseconds(target_work_milliseconds);

            while (items.IsNotEmpty())
            {
                if (items.GetFirst().GetTimestamp() > latest_timestamp)
                    return;
                else
                {
                    SchedulerItem<T> item = items.Pop();

                    process(item.GetData());

                    if (item.GetTimestamp() > earliest_timestamp && work_timer.IsTimeOver())
                        return;
                }
            }
        }

        public void Add(long timestamp, T data)
        {
            items.Add(new SchedulerItem<T>(timestamp, data));
        }
    }
}