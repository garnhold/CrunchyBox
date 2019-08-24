using System;

namespace CrunchyDough
{
    static public class TemporalDurationExtensions_State
    {
        static public long GetTimeTillInMilliseconds(this TemporalDuration item)
        {
            return item.GetDurationInMilliseconds() - item.GetElapsedTimeInMilliseconds();
        }

        static public long GetTimeLeftInMilliseconds(this TemporalDuration item)
        {
            return item.GetTimeTillInMilliseconds().BindAbove(0);
        }

        static public long GetTimeOverInMilliseconds(this TemporalDuration item)
        {
            return -item.GetTimeTillInMilliseconds().BindBelow(0);
        }

        static public bool IsTimeOver(this TemporalDuration item)
        {
            if (item.GetElapsedTimeInMilliseconds() >= item.GetDurationInMilliseconds())
                return true;

            return false;
        }

        static public bool IsTimeUnder(this TemporalDuration item)
        {
            if (item.IsTimeOver() == false)
                return true;

            return false;
        }

        static public bool IsTimeRunningUnder(this TemporalDuration item)
        {
            if (item.IsTimeUnder() && item.IsRunning())
                return true;

            return false;
        }

        static public bool IsTimeStoppedUnder(this TemporalDuration item)
        {
            if (item.IsTimeUnder() && item.IsStopped())
                return true;

            return false;
        }

        static public bool IsTimeRunningOver(this TemporalDuration item)
        {
            if (item.IsTimeOver() && item.IsRunning())
                return true;

            return false;
        }

        static public bool IsTimeStoppedOver(this TemporalDuration item)
        {
            if (item.IsTimeOver() && item.IsStopped())
                return true;

            return false;
        }
    }
}