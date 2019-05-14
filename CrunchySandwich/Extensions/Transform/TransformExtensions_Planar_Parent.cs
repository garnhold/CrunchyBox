using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class TransformExtensions_Planar_Parent
    {
        static public Vector2 GetParentPlanarPosition(this Transform item)
        {
            return item.parent.IfNotNull(p => p.GetPlanarPosition(), Vector2.zero);
        }
        static public Vector2 GetParentLocalPlanarPosition(this Transform item)
        {
            return item.parent.IfNotNull(p => p.GetLocalPlanarPosition(), Vector2.zero);
        }

        static public float GetParentPlanarRotation(this Transform item)
        {
            return item.parent.IfNotNull(p => p.GetPlanarRotation(), 0.0f);
        }
        static public float GetParentLocalPlanarRotation(this Transform item)
        {
            return item.parent.IfNotNull(p => p.GetLocalPlanarRotation(), 0.0f);
        }

        static public Vector2 GetParentPlanarScale(this Transform item)
        {
            return item.parent.IfNotNull(p => p.GetPlanarScale(), Vector2.one);
        }
        static public Vector2 GetParentLocalPlanarScale(this Transform item)
        {
            return item.parent.IfNotNull(p => p.GetLocalPlanarScale(), Vector2.one);
        }
    }
}