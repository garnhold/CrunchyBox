using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class ScreenAnchorExtensions_Interpolate
    {
        static public void InterpolateOffset(this ScreenAnchor item, Vector2 target, float amount)
        {
            item.SetOffset(item.GetOffset().GetInterpolate(target, amount));
        }

        static public void InterpolateSelfOriginOffsetPercent(this ScreenAnchor item, Vector2 target, float amount)
        {
            item.SetSelfOriginOffsetPercent(item.GetSelfOriginOffsetPercent().GetInterpolate(target, amount));
        }

        static public void InterpolateScreenOriginOffsetPercent(this ScreenAnchor item, Vector2 target, float amount)
        {
            item.SetScreenOriginOffsetPercent(item.GetScreenOriginOffsetPercent().GetInterpolate(target, amount));
        }
    }
}