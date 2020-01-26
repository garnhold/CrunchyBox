using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Vector2IntExtensions_Vector3Int
    {
        static public Vector3Int GetVector3Int(this Vector2Int item, int z)
        {
            return new Vector3Int(item.x, item.y, z);
        }
        static public Vector3Int GetVector3Int(this Vector2Int item)
        {
            return item.GetVector3Int(0);
        }
    }
}