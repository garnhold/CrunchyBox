using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class TransformExtensions_Planar_Interpolate
    {
        static public void InterpolatePlanarPosition(this Transform item, Vector2 target, float amount)
        {
            item.SetPlanarPosition(item.GetPlanarPosition().GetInterpolate(target, amount));
        }
        static public void InterpolateLocalPlanarPosition(this Transform item, Vector2 target, float amount)
        {
            item.SetLocalPlanarPosition(item.GetLocalPlanarPosition().GetInterpolate(target, amount));
        }

        static public void InterpolatePlanarRotation(this Transform item, float target, float amount)
        {
            item.SetPlanarRotation(item.GetPlanarRotation().GetInterpolateAngleInDegrees(target, amount));
        }
        static public void InterpolateLocalPlanarRotation(this Transform item, float target, float amount)
        {
            item.SetLocalPlanarRotation(item.GetLocalPlanarRotation().GetInterpolateAngleInDegrees(target, amount));
        }

        static public void InterpolatePlanarScale(this Transform item, Vector2 target, float amount)
        {
            item.SetPlanarScale(item.GetPlanarScale().GetInterpolate(target, amount));
        }
        static public void InterpolateLocalPlanarScale(this Transform item, Vector2 target, float amount)
        {
            item.SetLocalPlanarScale(item.GetLocalPlanarScale().GetInterpolate(target, amount));
        }

        static public void InterpolatePlanarScale(this Transform item, float target, float amount)
        {
            item.InterpolatePlanarScale(new Vector2(target, target), amount);
        }
        static public void InterpolateLocalPlanarScale(this Transform item, float target, float amount)
        {
            item.InterpolateLocalPlanarScale(new Vector2(target, target), amount);
        }
    }
}