using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class RectExtensions_IEnumerable_Boolean
    {
        static public Rect GetEncompassing(this IEnumerable<Rect> item)
        {
            return item.PerformIteratedBinaryOperation((r1, r2) => r1.GetEncompassing(r2));
        }
    }
}