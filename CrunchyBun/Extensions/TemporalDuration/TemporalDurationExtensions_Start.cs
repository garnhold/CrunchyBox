using System;

using CrunchyDough;

namespace CrunchyBun
{
    static public class TemporalDurationExtensions_Start
    {
        static public bool StartJittered(this TemporalDuration item)
        {
            return item.StartWithRandomElapsedTimeInMilliseconds(item.GetDurationInMilliseconds());
        }
    }
}