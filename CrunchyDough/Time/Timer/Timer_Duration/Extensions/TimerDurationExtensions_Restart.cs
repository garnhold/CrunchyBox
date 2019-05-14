using System;

namespace CrunchyDough
{
    static public class TimerDurationExtensions_Restart
    {
        static public void RestartSetDuration(this Timer_Duration item, Duration duration)
        {
            item.Restart();
            item.SetDuration(duration);
        }

        static public void RestartSetDurationInMilliseconds(this Timer_Duration item, long milliseconds)
        {
            item.RestartSetDuration(Duration.Milliseconds(milliseconds));
        }

        static public void RestartSetDurationInSeconds(this Timer_Duration item, float seconds)
        {
            item.RestartSetDuration(Duration.Seconds(seconds));
        }
    }
}