using System;

namespace CrunchyDough
{
    static public class TemporalDurationExtensions_Duration
    {
        static public void SetDuration(this TemporalDuration item, Duration duration)
        {
            item.SetDurationInMilliseconds((long)duration.GetMilliseconds());
        }

        static public Duration GetDuration(this TemporalDuration item)
        {
            return Duration.Milliseconds(item.GetDurationInMilliseconds());
        }

        static public Duration GetTimeLeft(this TemporalDuration item)
        {
            return Duration.Milliseconds(item.GetTimeLeftInMilliseconds());
        }

        static public Duration GetTimeOver(this TemporalDuration item)
        {
            return Duration.Milliseconds(item.GetTimeOverInMilliseconds());
        }

        static public Duration GetTimeTill(this TemporalDuration item)
        {
            return Duration.Milliseconds(item.GetTimeTillInMilliseconds());
        }
    }
}