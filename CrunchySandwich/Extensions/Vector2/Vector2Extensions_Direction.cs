using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class Vector2Extensions_Direction
    {
        static public Vector2 GetDirection(this Vector2 item, Vector2 target)
        {
            return (target - item).GetNormalized();
        }

        static public Vector2 GetDirection(this Vector2 item, Vector2 target, out float distance)
        {
            return (target - item).GetNormalized(out distance);
        }

        static public bool IsComplyingDirection(this Vector2 item, Vector2 direction)
        {
            if (item.GetDot(direction) > 0.0f)
                return true;

            return false;
        }

        static public bool IsOpposingDirection(this Vector2 item, Vector2 direction)
        {
            if (item.GetDot(direction) < 0.0f)
                return true;

            return false;
        }
    }
}