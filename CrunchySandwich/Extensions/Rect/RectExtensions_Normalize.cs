using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class RectExtensions_Normalize
    {
        static public Rect GetNormalized(this Rect item, Vector2 dimensions)
        {
            return new Rect(
                item.position.GetComponentDivide(dimensions),
                item.size.GetComponentDivide(dimensions)
            );
        }
    }
}