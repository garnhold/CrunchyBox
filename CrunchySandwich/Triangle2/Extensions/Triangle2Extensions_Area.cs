using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class Triangle2Extensions_Area
    {
        static public float GetArea(this Triangle2 item)
        {
            return item.GetPoints().GetLoopArea();
        }
    }
}