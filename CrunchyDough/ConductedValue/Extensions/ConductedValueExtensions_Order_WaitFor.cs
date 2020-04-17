using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ConductedValueExtensions_Order_WaitFor
    {
        static public ConductorOrder Order_WaitFor<T>(this ConductedValue<T> item, TemporalEvent temporal_event)
        {
            return new ConductorOrder_WaitFor(temporal_event);
        }

        static public ConductorOrder Order_WaitFor<T>(this ConductedValue<T> item, TemporalDuration temporal_duration)
        {
            return new ConductorOrder_WaitFor(temporal_duration);
        }

        static public ConductorOrder Order_WaitFor<T>(this ConductedValue<T> item, long duration, TimeSource time_source)
        {
            return new ConductorOrder_WaitFor(duration, time_source);
        }
        static public ConductorOrder Order_WaitFor<T>(this ConductedValue<T> item, long duration)
        {
            return new ConductorOrder_WaitFor(duration);
        }

        static public ConductorOrder Order_WaitFor<T>(this ConductedValue<T> item, Duration duration, TimeSource time_source)
        {
            return new ConductorOrder_WaitFor(duration, time_source);
        }
        static public ConductorOrder Order_WaitFor<T>(this ConductedValue<T> item, Duration duration)
        {
            return new ConductorOrder_WaitFor(duration);
        }
    }
}
