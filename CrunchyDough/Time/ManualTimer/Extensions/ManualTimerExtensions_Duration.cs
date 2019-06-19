using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class ManualTimerExtensions_Duration
    {
        static public void StepByDuration(this ManualTimer item, Duration duration)
        {
            item.StepByMilliseconds(duration.GetWholeMilliseconds());
        }
    }
}