using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class BoundsExtensions_Compare
    {
        static public bool IsCollapsed(this Bounds item, float tolerance)
        {
            if (item.size.x <= tolerance)
                return true;

            if (item.size.y <= tolerance)
                return true;

            if (item.size.z <= tolerance)
                return true;

            return false;
        }

        static public bool IsCollapsed(this Bounds item)
        {
            return item.IsCollapsed(0.0f);
        }
    }
}