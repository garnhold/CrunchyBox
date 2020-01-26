using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class BoundsExtensions_Split_Center
    {
        static public void SplitByXCenter(this Bounds item, out Bounds left, out Bounds right)
        {
            item.SplitByX(item.center.x, out left, out right);
        }

        static public void SplitByYCenter(this Bounds item, out Bounds bottom, out Bounds top)
        {
            item.SplitByY(item.center.y, out bottom, out top);
        }

        static public void SplitByZCenter(this Bounds item, out Bounds near, out Bounds far)
        {
            item.SplitByZ(item.center.z, out near, out far);
        }
    }
}