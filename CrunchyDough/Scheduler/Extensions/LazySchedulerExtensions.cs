using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class LazySchedulerExtensions
    {
        static public void Update(this LazyScheduler item, Duration target_frame_time, Duration lookahead)
        {
            item.Update(target_frame_time.GetWholeMilliseconds(), lookahead.GetWholeMilliseconds());
        }

        static public void Update(this LazyScheduler item, long target_frame_milliseconds)
        {
            item.Update(target_frame_milliseconds, Duration.Days(1.0f).GetWholeMilliseconds());
        }
        static public void Update(this LazyScheduler item, Duration target_frame_time)
        {
            item.Update(target_frame_time.GetWholeMilliseconds());
        }
    }
}