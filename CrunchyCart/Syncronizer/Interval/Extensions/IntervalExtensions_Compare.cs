using System;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public class IntervalExtensions_Compare
    {
        static public bool IsDefault(this Syncronizer.Interval item)
        {
            if (item == Syncronizer.Interval.Default)
                return true;

            return false;
        }
        static public bool IsNotDefault(this Syncronizer.Interval item)
        {
            if (item.IsDefault() == false)
                return true;

            return false;
        }

        static public Syncronizer.Interval GetMin(this Syncronizer.Interval item, Syncronizer.Interval other)
        {
            if (item < other)
                return item;

            return other;
        }
        static public Syncronizer.Interval GetMax(this Syncronizer.Interval item, Syncronizer.Interval other)
        {
            if (item > other)
                return item;

            return other;
        }
    }
}