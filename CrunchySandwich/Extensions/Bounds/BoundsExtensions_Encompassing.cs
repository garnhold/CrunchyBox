using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class BoundsExtensions_Encompassing
    {
        static public Bounds GetEncompassing(this Bounds item, Bounds bounds)
        {
            Bounds total = new Bounds(item.center, item.size);

            total.Encapsulate(bounds);
            return total;
        }

        static public Bounds GetEncompassing(this Bounds item, Vector3 point)
        {
            Bounds total = new Bounds(item.center, item.size);

            total.Encapsulate(point);
            return total;
        }
    }
}