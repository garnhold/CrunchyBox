using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class SchedulerExtensions_Add
    {
        static public void Add<T>(this Scheduler<T> item, Duration time, T data)
        {
            item.Add(time.GetWholeMilliseconds(), data);
        }
    }
}