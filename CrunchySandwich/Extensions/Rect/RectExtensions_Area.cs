using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class RectExtensions_Area
    {
        static public float GetArea(this Rect item)
        {
            return item.width * item.height;
        }
    }
}