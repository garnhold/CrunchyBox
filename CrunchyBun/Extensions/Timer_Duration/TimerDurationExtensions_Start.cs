using System;

using CrunchyDough;

namespace CrunchyBun
{
    static public class TimerDurationExtensions_Start
    {
        static public bool StartJittered(this Timer_Duration item)
        {
            return item.StartWithRandomElapsedTimeInMilliseconds(item.GetDurationInMilliseconds());
        }
    }
}