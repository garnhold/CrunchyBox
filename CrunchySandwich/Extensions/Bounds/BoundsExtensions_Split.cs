using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class BoundsExtensions_Split
    {
        static public void SplitByX(this Bounds item, float x, out Bounds left, out Bounds right)
        {
            float split = x.Min(item.max.x);

            left = BoundsExtensions.CreateStrictMinMaxBounds(item.min, item.max.GetWithX(split));
            right = BoundsExtensions.CreateStrictMinMaxBounds(item.min.GetWithX(split), item.max);
        }
        static public void SplitByXLeftOffset(this Bounds item, float offset, out Bounds left, out Bounds right)
        {
            item.SplitByX(item.min.x + offset, out left, out right);
        }
        static public void SplitByXRightOffset(this Bounds item, float offset, out Bounds left, out Bounds right)
        {
            item.SplitByX(item.max.x - offset, out left, out right);
        }

        static public void SplitByY(this Bounds item, float y, out Bounds bottom, out Bounds top)
        {
            float split = y.Min(item.max.y);

            bottom = BoundsExtensions.CreateStrictMinMaxBounds(item.min, item.max.GetWithY(split));
            top = BoundsExtensions.CreateStrictMinMaxBounds(item.min.GetWithY(split), item.max);
        }
        static public void SplitByYBottomOffset(this Bounds item, float offset, out Bounds bottom, out Bounds top)
        {
            item.SplitByY(item.min.y + offset, out bottom, out top);
        }
        static public void SplitByYTopOffset(this Bounds item, float offset, out Bounds bottom, out Bounds top)
        {
            item.SplitByY(item.max.y - offset, out bottom, out top);
        }

        static public void SplitByZ(this Bounds item, float z, out Bounds near, out Bounds far)
        {
            float split = z.Min(item.max.z);

            near = BoundsExtensions.CreateStrictMinMaxBounds(item.min, item.max.GetWithZ(split));
            far = BoundsExtensions.CreateStrictMinMaxBounds(item.min.GetWithZ(split), item.max);
        }
        static public void SplitByZNearOffset(this Bounds item, float offset, out Bounds near, out Bounds far)
        {
            item.SplitByZ(item.min.z + offset, out near, out far);
        }
        static public void SplitByZFarOffset(this Bounds item, float offset, out Bounds near, out Bounds far)
        {
            item.SplitByZ(item.max.z - offset, out near, out far);
        }
    }
}