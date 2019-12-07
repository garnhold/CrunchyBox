using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class RectExtensions_Compare
    {
        static public bool IsCollapsed(this Rect item, float tolerance)
        {
            if (item.width <= tolerance)
                return true;

            if (item.height <= tolerance)
                return true;

            return false;
        }

        static public bool IsCollapsed(this Rect item)
        {
            return item.IsCollapsed(0.0f);
        }
    }
}