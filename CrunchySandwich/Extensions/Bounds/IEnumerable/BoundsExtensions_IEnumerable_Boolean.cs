using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class BoundsExtensions_IEnumerable_Boolean
    {
        static public Bounds GetEncompassing(this IEnumerable<Bounds> item)
        {
            return item.PerformIteratedBinaryOperation((b1, b2) => b1.GetEncompassing(b2));
        }
    }
}