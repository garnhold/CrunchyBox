using System;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

namespace Crunchy.Cart
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public class IntervalExtensions_ResolveDefault
    {
        static public Syncronizer.Interval ResolveDefault(this Syncronizer.Interval item, Syncronizer.Interval alternative)
        {
            if (item.IsNotDefault())
                return item;

            return alternative;
        }
    }
}