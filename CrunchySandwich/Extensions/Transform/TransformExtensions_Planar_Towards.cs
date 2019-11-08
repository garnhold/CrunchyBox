using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class TransformExtensions_Planar_Towards
    {
        static public void TowardsPlanarPosition(this Transform item, Vector2 target, Vector2 amount)
        {
            item.SetPlanarPosition(item.GetPlanarPosition().GetTowards(target, amount));
        }
        static public void TowardsLocalPlanarPosition(this Transform item, Vector2 target, Vector2 amount)
        {
            item.SetLocalPlanarPosition(item.GetLocalPlanarPosition().GetTowards(target, amount));
        }

        static public void TowardsPlanarPosition(this Transform item, Vector2 target, float amount)
        {
            item.SetPlanarPosition(item.GetPlanarPosition().GetTowards(target, amount));
        }
        static public void TowardsLocalPlanarPosition(this Transform item, Vector2 target, float amount)
        {
            item.SetLocalPlanarPosition(item.GetLocalPlanarPosition().GetTowards(target, amount));
        }

        static public void TowardsPlanarRotation(this Transform item, float target, float amount)
        {
            item.SetPlanarRotation(item.GetPlanarRotation().GetTowardsAngleInDegrees(target, amount));
        }
        static public void TowardsLocalPlanarRotation(this Transform item, float target, float amount)
        {
            item.SetLocalPlanarRotation(item.GetLocalPlanarRotation().GetTowardsAngleInDegrees(target, amount));
        }

        static public void TowardsPlanarScale(this Transform item, Vector2 target, Vector2 amount)
        {
            item.SetPlanarScale(item.GetPlanarScale().GetTowards(target, amount));
        }
        static public void TowardsLocalPlanarScale(this Transform item, Vector2 target, Vector2 amount)
        {
            item.SetLocalPlanarScale(item.GetLocalPlanarScale().GetTowards(target, amount));
        }

        static public void TowardsPlanarScale(this Transform item, float target, float amount)
        {
            item.TowardsPlanarScale(new Vector2(target, target), new Vector2(amount, amount));
        }
        static public void TowardsLocalPlanarScale(this Transform item, float target, float amount)
        {
            item.TowardsLocalPlanarScale(new Vector2(target, target), new Vector2(amount, amount));
        }
    }
}