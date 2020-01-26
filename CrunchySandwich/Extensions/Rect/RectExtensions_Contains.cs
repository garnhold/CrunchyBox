using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class RectExtensions_Contains
    {
        static public bool FullyContains(this Rect item, Rect target)
        {
            if (item.xMin <= target.xMin && item.xMax >= target.xMax)
            {
                if (item.yMin <= target.yMin && item.yMax >= target.yMax)
                    return true;
            }

            return false;
        }

        static public bool CouldContain(this Rect item, Rect target)
        {
            if (item.width >= target.width)
            {
                if (item.height >= target.height)
                    return true;
            }

            return false;
        }
    }
}