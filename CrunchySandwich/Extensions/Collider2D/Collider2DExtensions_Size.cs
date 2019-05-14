using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Collider2DExtensions_Size
    {
        static public Vector2 GetSize(this Collider2D item)
        {
            return item.bounds.GetPlanarSize();
        }

        static public Vector2 GetExtents(this Collider2D item)
        {
            return item.GetSize() * 0.5f;
        }
    }
}