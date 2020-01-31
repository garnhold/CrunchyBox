using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class TransformExtensions_Arear_Parent
    {
        static public Vector2 GetParentArearPosition(this Transform item)
        {
            return item.parent.IfNotNull(p => p.GetArearPosition(), Vector2.zero);
        }
        static public Vector2 GetParentLocalArearPosition(this Transform item)
        {
            return item.parent.IfNotNull(p => p.GetLocalArearPosition(), Vector2.zero);
        }

        static public float GetParentArearRotation(this Transform item)
        {
            return item.parent.IfNotNull(p => p.GetArearRotation(), 0.0f);
        }
        static public float GetParentLocalArearRotation(this Transform item)
        {
            return item.parent.IfNotNull(p => p.GetLocalArearRotation(), 0.0f);
        }

        static public Vector2 GetParentArearScale(this Transform item)
        {
            return item.parent.IfNotNull(p => p.GetArearScale(), Vector2.one);
        }
        static public Vector2 GetParentLocalArearScale(this Transform item)
        {
            return item.parent.IfNotNull(p => p.GetLocalArearScale(), Vector2.one);
        }
    }
}