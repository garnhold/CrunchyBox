using System;

namespace Crunchy.Dough
{
    static public class TemporalDurationExtensions_Start
    {
        static public bool StartSetDuration(this TemporalDuration item, Duration duration)
        {
            if (item.Start())
            {
                item.SetDuration(duration);

                return true;
            }

            return false;
        }

        static public bool StartSetDurationInMilliseconds(this TemporalDuration item, long milliseconds)
        {
            return item.StartSetDuration(Duration.Milliseconds(milliseconds));
        }

        static public bool StartSetDurationInSeconds(this TemporalDuration item, float seconds)
        {
            return item.StartSetDuration(Duration.Seconds(seconds));
        }

        static public bool StartJittered(this TemporalDuration item)
        {
            return item.StartWithRandomElapsedTimeInMilliseconds(item.GetDurationInMilliseconds());
        }
    }
}