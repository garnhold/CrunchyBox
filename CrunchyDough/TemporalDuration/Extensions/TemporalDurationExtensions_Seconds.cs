using System;

namespace CrunchyDough
{
    static public class TemporalDurationExtensions_Seconds
    {
        static public void SetDurationInSeconds(this TemporalDuration item, float seconds)
        {
            item.SetDuration(Duration.Seconds(seconds));
        }

        static public float GetDurationInSeconds(this TemporalDuration item)
        {
            return item.GetDuration().GetSeconds();
        }

        static public float GetTimeLeftInSeconds(this TemporalDuration item)
        {
            return item.GetTimeLeft().GetSeconds();
        }

        static public float GetTimeOverInSeconds(this TemporalDuration item)
        {
            return item.GetTimeOver().GetSeconds();
        }

        static public float GetTimeTillInSeconds(this TemporalDuration item)
        {
            return item.GetTimeTill().GetSeconds();
        }
    }
}