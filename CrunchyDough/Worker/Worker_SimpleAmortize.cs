using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class Worker_SimpleAmortize<T> : Worker<T>
    {
        private Stopwatch frame_timer;

        protected override void WorkInternal(WorkCollection<T> work_collection)
        {
            long milliseconds_per_frame = frame_timer.GetElapsedTimeInMilliseconds();
            float interval_per_frame = (float)milliseconds_per_frame / (float)GetWorkIntervalInMilliseconds();

            work_collection.WorkPercent(interval_per_frame);
            frame_timer.Restart();
        }

        public Worker_SimpleAmortize(long i, Process<T> p, TimeSource t) : base(i, p, t)
        {
            frame_timer = new Stopwatch(t);
        }

        public Worker_SimpleAmortize(long i, Process<T> p) : this(i, p, TimeSource_System.INSTANCE) { }

        public Worker_SimpleAmortize(Duration i, Process<T> p, TimeSource t) : this(i.GetWholeMilliseconds(), p, t) { }
        public Worker_SimpleAmortize(Duration i, Process<T> p) : this(i, p, TimeSource_System.INSTANCE) { }
    }
}