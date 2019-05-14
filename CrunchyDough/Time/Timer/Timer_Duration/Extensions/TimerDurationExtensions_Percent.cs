using System;

namespace CrunchyDough
{
    static public class TimerDurationExtensions_Percent
    {
        static public float GetTimeElapsedInPercent(this Timer_Duration item)
        {
            return (float)item.GetElapsedTimeInMilliseconds() / (float)item.GetDurationInMilliseconds();
        }

        static public float GetTimeLeftInPercent(this Timer_Duration item)
        {
            return (float)item.GetTimeLeftInMilliseconds() / (float)item.GetDurationInMilliseconds();
        }

        static public float GetTimeOverInPercent(this Timer_Duration item)
        {
            return (float)item.GetTimeOverInMilliseconds() / (float)item.GetDurationInMilliseconds();
        }

        static public float GetTimeTillInPercent(this Timer_Duration item)
        {
            return (float)item.GetTimeTillInMilliseconds() / (float)item.GetDurationInMilliseconds();
        }
    }
}