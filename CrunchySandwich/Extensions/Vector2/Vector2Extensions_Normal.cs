using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class Vector2Extensions_Normal
    {
        static public Vector2 GetNormal(this Vector2 item)
        {
            return new Vector2(-item.y, item.x);
        }
        static public Vector2 GetNormal(this Vector2 item, Vector2 point)
        {
            return (point - item).GetNormal();
        }

        static public Vector2 GetNormalizedNormal(this Vector2 item)
        {
            return item.GetNormal().normalized;
        }
        static public Vector2 GetNormalizedNormal(this Vector2 item, Vector2 point)
        {
            return (point - item).GetNormalizedNormal();
        }

        static public Vector2 GetNormalizedNormal(this Vector2 item, Vector2 before, Vector2 after)
        {
            return (before.GetNormalizedNormal(item) + item.GetNormalizedNormal(after)) * 0.5f;
        }
    }
}