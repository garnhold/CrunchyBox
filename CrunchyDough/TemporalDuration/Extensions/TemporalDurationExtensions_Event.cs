using System;

namespace CrunchyDough
{
    static public class TemporalDurationExtensions_Event
    {
        static public TemporalEvent GetAsTemporalEvent(this TemporalDuration item)
        {
            return new TemporalEvent_Duration(item);
        }
    }
}