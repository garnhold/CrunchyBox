using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class WorkSystemExtensions_Schedule
    {
        static public void Schedule(this WorkSystem item, UnityEngine.Object requester, Duration max_delay, Process process)
        {
            item.Schedule(requester, max_delay.GetWholeMilliseconds(), process);
        }
    }
}