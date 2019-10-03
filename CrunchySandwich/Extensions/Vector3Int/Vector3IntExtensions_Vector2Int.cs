using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector3IntExtensions_Vector2Int
    {
        static public Vector2Int GetVector2Int(this Vector3Int item)
        {
            return new Vector2Int(item.x, item.y);
        }
    }
}