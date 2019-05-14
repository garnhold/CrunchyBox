using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector2Extensions_Space
    {
        static public Vector3 GetSpacar(this Vector2 item, float z)
        {
            return new Vector3(item.x, item.y, z);
        }

        static public Vector3 GetSpacar(this Vector2 item)
        {
            return item.GetSpacar(0.0f);
        }
    }
}