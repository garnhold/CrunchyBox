using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector3Extensions_Direction
    {
        static public Vector3 GetDirection(this Vector3 item, Vector3 target)
        {
            return (target - item).GetNormalized();
        }

        static public Vector3 GetDirection(this Vector3 item, Vector3 target, out float distance)
        {
            return (target - item).GetNormalized(out distance);
        }

        static public bool IsComplyingDirection(this Vector3 item, Vector3 direction)
        {
            if (item.GetDot(direction) > 0.0f)
                return true;

            return false;
        }

        static public bool IsOpposingDirection(this Vector3 item, Vector3 direction)
        {
            if (item.GetDot(direction) < 0.0f)
                return true;

            return false;
        }
    }
}