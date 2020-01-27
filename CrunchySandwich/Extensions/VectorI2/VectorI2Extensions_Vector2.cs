using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class VectorI2Extensions_Vector2
    {
        static public Vector2 GetVector2(this VectorI2 item)
        {
            return new Vector2(item.x, item.y);
        }
    }
}