using System;

namespace CrunchyDough
{
    static public class TimerDurationExtensions_Duration
    {
        static public void SetDuration(this Timer_Duration item, Duration duration)
        {
            item.SetDurationInMilliseconds((long)duration.GetMilliseconds());
        }

        static public Duration GetDuration(this Timer_Duration item)
        {
            return Duration.Milliseconds(item.GetDurationInMilliseconds());
        }

        static public Duration GetTimeLeft(this Timer_Duration item)
        {
            return Duration.Milliseconds(item.GetTimeLeftInMilliseconds());
        }

        static public Duration GetTimeOver(this Timer_Duration item)
        {
            return Duration.Milliseconds(item.GetTimeOverInMilliseconds());
        }

        static public Duration GetTimeTill(this Timer_Duration item)
        {
            return Duration.Milliseconds(item.GetTimeTillInMilliseconds());
        }
    }
}