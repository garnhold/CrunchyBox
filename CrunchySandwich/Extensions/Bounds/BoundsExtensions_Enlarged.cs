using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class BoundsExtensions_Enlarged
    {
        static public Bounds GetEnlarged(this Bounds item, Vector3 amount)
        {
            return new Bounds(item.center, item.size + amount * 2.0f);
        }

        static public Bounds GetEnlarged(this Bounds item, float amount)
        {
            return item.GetEnlarged(new Vector3(amount, amount, amount));
        }
    }
}