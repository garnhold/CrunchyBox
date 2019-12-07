using System;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    using Sodium;
    
    static public class IntervalIEnumerableExtensions_Compare
    {
        static public Syncronizer.Interval Min(this IEnumerable<Syncronizer.Interval> item)
        {
            return item.PerformIteratedBinaryOperation((i1, i2) => i1.GetMin(i2));
        }
        static public Syncronizer.Interval Max(this IEnumerable<Syncronizer.Interval> item)
        {
            return item.PerformIteratedBinaryOperation((i1, i2) => i1.GetMax(i2));
        }
    }
}