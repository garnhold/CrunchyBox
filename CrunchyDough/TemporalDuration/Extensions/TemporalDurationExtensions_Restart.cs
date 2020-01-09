using System;

namespace Crunchy.Dough
{
    static public class TemporalDurationExtensions_Restart
    {
        static public void RestartSetDuration(this TemporalDuration item, Duration duration)
        {
            item.Restart();
            item.SetDuration(duration);
        }

        static public void RestartSetDurationInMilliseconds(this TemporalDuration item, long milliseconds)
        {
            item.RestartSetDuration(Duration.Milliseconds(milliseconds));
        }

        static public void RestartSetDurationInSeconds(this TemporalDuration item, float seconds)
        {
            item.RestartSetDuration(Duration.Seconds(seconds));
        }
    }
}