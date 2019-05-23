using System;
using System.Collections;
using System.Collections.Generic;

using Lidgren.Network;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchySodium;

namespace CrunchyCart
{
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