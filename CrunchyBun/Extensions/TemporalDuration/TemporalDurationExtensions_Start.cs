using System;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class TemporalDurationExtensions_Start
    {
        static public bool StartJittered(this TemporalDuration item)
        {
            return item.StartWithRandomElapsedTimeInMilliseconds(item.GetDurationInMilliseconds());
        }
    }
}