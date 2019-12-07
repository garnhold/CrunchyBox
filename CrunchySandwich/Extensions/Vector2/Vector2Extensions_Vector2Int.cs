using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class Vector2Extensions_Vector2Int
    {
        static public Vector2Int GetVector2Int(this Vector2 item)
        {
            return new Vector2Int((int)item.x, (int)item.y);
        }
    }
}