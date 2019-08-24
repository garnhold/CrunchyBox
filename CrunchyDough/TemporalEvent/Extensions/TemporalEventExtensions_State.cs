using System;

namespace CrunchyDough
{
    static public class TemporalEventExtensions_State
    {
        static public bool IsTimeUnder(this TemporalEvent item)
        {
            if (item.IsTimeOver() == false)
                return true;

            return false;
        }

        static public bool IsTimeRunningUnder(this TemporalEvent item)
        {
            if (item.IsTimeUnder() && item.IsRunning())
                return true;

            return false;
        }

        static public bool IsTimeStoppedUnder(this TemporalEvent item)
        {
            if (item.IsTimeUnder() && item.IsStopped())
                return true;

            return false;
        }

        static public bool IsTimeRunningOver(this TemporalEvent item)
        {
            if (item.IsTimeOver() && item.IsRunning())
                return true;

            return false;
        }

        static public bool IsTimeStoppedOver(this TemporalEvent item)
        {
            if (item.IsTimeOver() && item.IsStopped())
                return true;

            return false;
        }
    }
}