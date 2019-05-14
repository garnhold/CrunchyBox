using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class VectorF2Extensions_Vector2
    {
        static public Vector2 GetVector2(this VectorF2 item)
        {
            return new Vector2(item.x, item.y);
        }
    }
}