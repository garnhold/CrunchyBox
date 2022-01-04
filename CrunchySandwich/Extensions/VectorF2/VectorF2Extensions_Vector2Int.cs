using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class VectorF2Extensions_Vector2Int
    {
        static public Vector2Int GetVector2Int(this VectorF2 item)
        {
            return new Vector2Int((int)item.x, (int)item.y);
        }
    }
}