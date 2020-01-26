using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class TransformExtensions_Planar_Adjust
    {
        static public void AdjustPlanarPosition(this Transform item, Vector2 amount)
        {
            item.SetPlanarPosition(item.GetPlanarPosition() + amount);
        }
        static public void AdjustLocalPlanarPosition(this Transform item, Vector2 amount)
        {
            item.SetLocalPlanarPosition(item.GetLocalPlanarPosition() + amount);
        }

        static public void AdjustPlanarRotation(this Transform item, float amount)
        {
            item.SetPlanarRotation(item.GetPlanarRotation() + amount);
        }
        static public void AdjustLocalPlanarRotation(this Transform item, float amount)
        {
            item.SetLocalPlanarRotation(item.GetLocalPlanarRotation() + amount);
        }

        static public void AdjustPlanarScale(this Transform item, Vector2 amount)
        {
            item.SetPlanarScale(item.GetPlanarScale() + amount);
        }
        static public void AdjustLocalPlanarScale(this Transform item, Vector2 amount)
        {
            item.SetLocalPlanarScale(item.GetLocalPlanarScale() + amount);
        }
    }
}