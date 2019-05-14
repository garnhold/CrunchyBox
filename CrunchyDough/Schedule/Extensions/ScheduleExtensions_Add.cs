using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class ScheduleExtensions_Add
    {
        static public void AddAt<T>(this Schedule<T> item, Duration time, T data)
        {
            item.AddAt(time.GetWholeMilliseconds(), data);
        }

        static public void AddIn<T>(this Schedule<T> item, Duration delay, T data)
        {
            item.AddIn(delay.GetWholeMilliseconds(), data);
        }
    }
}