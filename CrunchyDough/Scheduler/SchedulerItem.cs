using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class SchedulerItem<T>
    {
        private long timestamp;
        private T data;

        public SchedulerItem(long t, T d)
        {
            timestamp = t;
            data = d;
        }

        public long GetTimestamp()
        {
            return timestamp;
        }

        public T GetData()
        {
            return data;
        }
    }
}