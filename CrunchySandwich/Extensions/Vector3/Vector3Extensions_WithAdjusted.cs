using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Vector3Extensions_WithAdjusted
    {
        static public Vector3 GetWithAdjustedX(this Vector3 item, float x)
        {
            return item.GetWithX(item.x + x);
        }

        static public Vector3 GetWithAdjustedY(this Vector3 item, float y)
        {
            return item.GetWithY(item.y + y);
        }

        static public Vector3 GetWithAdjustedZ(this Vector3 item, float z)
        {
            return item.GetWithZ(item.z + z);
        }

        static public Vector3 GetWithAdjustedXY(this Vector3 item, float x, float y)
        {
            return item.GetWithXY(item.x + x, item.y + y);
        }
        static public Vector3 GetWithAdjustedXY(this Vector3 item, Vector2 vector)
        {
            return item.GetWithAdjustedXY(vector.x, vector.y);
        }

        static public Vector3 GetWithAdjustedXZ(this Vector3 item, float x, float z)
        {
            return item.GetWithXZ(item.x + x, item.z + z);
        }

        static public Vector3 GetWithAdjustedYZ(this Vector3 item, float y, float z)
        {
            return item.GetWithYZ(item.y + y, item.z + z);
        }
    }
}