using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public abstract class Worker<T>
    {
        private RateLimiter rate_limiter;
        private WorkCollection<T> work_collection;

        protected virtual void StartWorkInternal(WorkCollection<T> work_collection) { }
        protected abstract void WorkInternal(WorkCollection<T> work_collection);

        public Worker(long i, Process<T> p, TimeSource t)
        {
            rate_limiter = new RateLimiter(i, t);
            work_collection = new WorkCollection<T>(p);
        }

        public Worker(long i, Process<T> p) : this(i, p, TimeSource_Stopwatch.INSTANCE) { }

        public Worker(Duration i, Process<T> p, TimeSource t) : this(i.GetWholeMilliseconds(), p, t) { }
        public Worker(Duration i, Process<T> p) : this(i, p, TimeSource_Stopwatch.INSTANCE) { }

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
            rate_limiter.Process(delegate() {
                work_collection.StartWork();

                StartWorkInternal(work_collection);
            });

            WorkInternal(work_collection);
        }

        public long GetWorkIntervalInMilliseconds()
        {
            return rate_limiter.GetIntervalInMilliseconds();
        }
    }
}