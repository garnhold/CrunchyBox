using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class SchedulerExtensions_Work
    {
        static public void Work<T>(this Scheduler<T> item, Duration time, Duration target_work_duration)
        {
            item.Work(time.GetWholeMilliseconds(), target_work_duration.GetWholeMilliseconds());
        }
    }
}