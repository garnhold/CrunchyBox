using System;

namespace CrunchyDough
{
    static public class TimerExtensions_Start
    {
        static public bool StartSetElapsedTime(this Timer item, Duration duration)
        {
            if (item.Start())
            {
                item.SetElapsedTime(duration);

                return true;
            }

            return false;
        }

        static public bool StartSetElapsedTimeInMilliseconds(this Timer item, long milliseconds)
        {
            return item.StartSetElapsedTime(Duration.Milliseconds(milliseconds));
        }

        static public bool StartSetElapsedTimeInSeconds(this Timer item, float seconds)
        {
            return item.StartSetElapsedTime(Duration.Seconds(seconds));
        }
    }
}