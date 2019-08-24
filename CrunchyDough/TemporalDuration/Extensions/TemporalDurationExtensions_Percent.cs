using System;

namespace CrunchyDough
{
    static public class TemporalDurationExtensions_Percent
    {
        static public float GetTimeElapsedInPercent(this TemporalDuration item)
        {
            return (float)item.GetElapsedTimeInMilliseconds() / (float)item.GetDurationInMilliseconds();
        }

        static public float GetTimeLeftInPercent(this TemporalDuration item)
        {
            return (float)item.GetTimeLeftInMilliseconds() / (float)item.GetDurationInMilliseconds();
        }

        static public float GetTimeOverInPercent(this TemporalDuration item)
        {
            return (float)item.GetTimeOverInMilliseconds() / (float)item.GetDurationInMilliseconds();
        }

        static public float GetTimeTillInPercent(this TemporalDuration item)
        {
            return (float)item.GetTimeTillInMilliseconds() / (float)item.GetDurationInMilliseconds();
        }
    }
}