using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector2Extensions_VectorF2
    {
        static public VectorF2 GetVectorF2(this Vector2 item)
        {
            return new VectorF2(item.x, item.y);
        }
    }
}