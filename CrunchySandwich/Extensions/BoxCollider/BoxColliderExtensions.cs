using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class BoxColliderExtensions
    {
        static public void SetBounds(this BoxCollider item, Bounds bounds)
        {
            item.center = bounds.center;
            item.size = bounds.size;
        }

        static public Bounds GetBounds(this BoxCollider item)
        {
            return new Bounds(item.center, item.size);
        }
    }
}