using System;

namespace CrunchyDough
{
    static public class TimerDurationExtensions_Seconds
    {
        static public void SetDurationInSeconds(this Timer_Duration item, float seconds)
        {
            item.SetDuration(Duration.Seconds(seconds));
        }

        static public float GetDurationInSeconds(this Timer_Duration item)
        {
            return item.GetDuration().GetSeconds();
        }

        static public float GetTimeLeftInSeconds(this Timer_Duration item)
        {
            return item.GetTimeLeft().GetSeconds();
        }

        static public float GetTimeOverInSeconds(this Timer_Duration item)
        {
            return item.GetTimeOver().GetSeconds();
        }

        static public float GetTimeTillInSeconds(this Timer_Duration item)
        {
            return item.GetTimeTill().GetSeconds();
        }
    }
}