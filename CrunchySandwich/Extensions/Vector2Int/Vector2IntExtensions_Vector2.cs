using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class Vector2IntExtensions_Vector2
    {
        static public Vector2 GetVector2(this Vector2Int item)
        {
            return new Vector2(item.x, item.y);
        }
    }
}