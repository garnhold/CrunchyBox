using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class BoundsExtensions_Scaled
    {
        static public Bounds GetScaled(this Bounds item, Vector3 amount)
        {
            return new Bounds(item.center, item.size.GetComponentMultiply(amount));
        }

        static public Bounds GetScaled(this Bounds item, float amount)
        {
            return item.GetScaled(new Vector3(amount, amount, amount));
        }
    }
}