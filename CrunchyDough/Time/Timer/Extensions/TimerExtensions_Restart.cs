using System;

namespace CrunchyDough
{
    static public class TimerExtensions_Restart
    {
        static public void RestartSetElapsedTime(this Timer item, Duration duration)
        {
            item.Restart();
            item.SetElapsedTime(duration);
        }

        static public void RestartSetElapsedTimeInMilliseconds(this Timer item, long milliseconds)
        {
            item.RestartSetElapsedTime(Duration.Milliseconds(milliseconds));
        }

        static public void RestartSetElapsedTimeInSeconds(this Timer item, float seconds)
        {
            item.RestartSetElapsedTime(Duration.Seconds(seconds));
        }
    }
}