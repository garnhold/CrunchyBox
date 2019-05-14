using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector3Extensions_With
    {
        static public Vector3 GetWithX(this Vector3 item, float x)
        {
            return new Vector3(x, item.y, item.z);
        }

        static public Vector3 GetWithY(this Vector3 item, float y)
        {
            return new Vector3(item.x, y, item.z);
        }

        static public Vector3 GetWithZ(this Vector3 item, float z)
        {
            return new Vector3(item.x, item.y, z);
        }

        static public Vector3 GetWithXY(this Vector3 item, float x, float y)
        {
            return new Vector3(x, y, item.z);
        }
        static public Vector3 GetWithXY(this Vector3 item, Vector2 vector)
        {
            return item.GetWithXY(vector.x, vector.y);
        }

        static public Vector3 GetWithXZ(this Vector3 item, float x, float z)
        {
            return new Vector3(x, item.y, z);
        }

        static public Vector3 GetWithYZ(this Vector3 item, float y, float z)
        {
            return new Vector3(item.x, y, z);
        }
    }
}