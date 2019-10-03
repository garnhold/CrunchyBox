using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector3IntExtensions_Vector3
    {
        static public Vector3 GetVector3(this Vector3Int item)
        {
            return new Vector3(item.x, item.y, item.z);
        }
    }
}