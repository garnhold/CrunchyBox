using System;

namespace CrunchyDough
{
    static public class TimerDurationExtensions_Start
    {
        static public bool StartSetDuration(this Timer_Duration item, Duration duration)
        {
            if (item.Start())
            {
                item.SetDuration(duration);

                return true;
            }

            return false;
        }

        static public bool StartSetDurationInMilliseconds(this Timer_Duration item, long milliseconds)
        {
            return item.StartSetDuration(Duration.Milliseconds(milliseconds));
        }

        static public bool StartSetDurationInSeconds(this Timer_Duration item, float seconds)
        {
            return item.StartSetDuration(Duration.Seconds(seconds));
        }
    }
}