using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector2Extensions_IEnumerable_Winding
    {
        static public IEnumerable<Vector2> WindClockwise(this IEnumerable<Vector2> item)
        {
            if (item.IsLoopClockwise())
                return item;

            return item.Reverse();
        }
        static public IEnumerable<Vector2> WindCounterClockwise(this IEnumerable<Vector2> item)
        {
            if (item.IsLoopCounterClockwise())
                return item;

            return item.Reverse();
        }
    }
}