using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class DecayTimeSetExtensions_Add
    {
        static public bool Add<T>(this DecayTimeSet<T> item, T to_add, Operation<TemporalDuration> operation, bool recharge)
        {
            return item.Add(to_add, () => new TemporalEvent_Duration(operation()), recharge);
        }

        static public bool Add<T>(this DecayTimeSet<T> item, T to_add, long duration, TimeSource time_source, bool recharge)
        {
            return item.Add(to_add, () => new Timer(duration, time_source), recharge);
        }
        static public bool Add<T>(this DecayTimeSet<T> item, T to_add, long duration, bool recharge)
        {
            return item.Add(to_add, duration, TimeSource_System.INSTANCE, recharge);
        }

        static public bool Add<T>(this DecayTimeSet<T> item, T to_add, Duration duration, TimeSource time_source, bool recharge)
        {
            return item.Add(to_add, () => new Timer(duration, time_source), recharge);
        }
        static public bool Add<T>(this DecayTimeSet<T> item, T to_add, Duration duration, bool recharge)
        {
            return item.Add(to_add, duration, TimeSource_System.INSTANCE, recharge);
        }
    }
}