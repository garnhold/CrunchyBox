using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class ManualTimerExtensions_Seconds
    {
        static public void StepBySeconds(this ManualTimer item, float seconds)
        {
            item.StepByDuration(Duration.Seconds(seconds));
        }
    }
}