using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector3Extensions_Axis
    {
        static public float GetComponent(this Vector3 item, Axis axis)
        {
            switch (axis)
            {
                case Axis.X: return item.x;
                case Axis.Y: return item.y;
                case Axis.Z: return item.z;
            }

            throw new UnaccountedBranchException("axis", axis);
        }

        static public Vector3 GetWith(this Vector3 item, Axis axis, float value)
        {
            switch (axis)
            {
                case Axis.X: return item.GetWithX(value);
                case Axis.Y: return item.GetWithY(value);
                case Axis.Z: return item.GetWithZ(value);
            }

            throw new UnaccountedBranchException("axis", axis);
        }
    }
}