using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector2Extensions_VectorI2
    {
        static public VectorI2 GetVectorI2(this Vector2 item)
        {
            return new VectorI2(item.x, item.y);
        }

        static public VectorI2 GetDeflated(this Vector2 item, Vector2 unit)
        {
            return item.GetComponentDivide(unit).GetVectorI2();
        }
    }
}