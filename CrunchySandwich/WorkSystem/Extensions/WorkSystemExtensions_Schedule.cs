using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class WorkSystemExtensions_Schedule
    {
        static public void Schedule(this WorkSystem item, Duration max_delay, Process process)
        {
            item.Schedule(max_delay.GetWholeMilliseconds(), process);
        }
    }
}