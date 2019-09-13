using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public abstract class Worker<T>
    {
        private Timer timer;
        private WorkCollection<T> work_collection;

        protected virtual void StartWorkInternal(WorkCollection<T> work_collection) { }
        protected abstract void WorkInternal(WorkCollection<T> work_collection);

        public Worker(long i, Process<T> p, TimeSource t)
        {
            timer = new Timer(i, t).StartExpireAndGet();
            work_collection = new WorkCollection<T>(p);
        }

        public Worker(long i, Process<T> p) : this(i, p, TimeSource_System.INSTANCE) { }

        public Worker(Duration i, Process<T> p, TimeSource t) : this(i.GetWholeMilliseconds(), p, t) { }
        public Worker(Duration i, Process<T> p) : this(i, p, TimeSource_System.INSTANCE) { }

        public void Clear()
        {
            work_collection.Clear();
        }

        public void Add(T to_add)
        {
            work_collection.Add(to_add);
        }

        public void Remove(T to_remove)
        {
            work_collection.Remove(to_remove);
        }

        public void Work()
        {
            if (timer.Repeat())
            {
                work_collection.StartWork();

                StartWorkInternal(work_collection);
            }

            WorkInternal(work_collection);
        }

        public long GetWorkIntervalInMilliseconds()
        {
            return timer.GetDurationInMilliseconds();
        }
    }
}