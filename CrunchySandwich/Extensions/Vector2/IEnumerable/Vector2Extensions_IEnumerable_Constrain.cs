using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector2Extensions_IEnumerable_Constrain
    {
        static public IEnumerable<Vector2> Constrain(this IEnumerable<Vector2> item, Rect rect)
        {
            rect.GetEncompassing()sdf
        }
    }
}