using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class Triangle2Extensions_Points
    {
        static public Vector2 GetCenter(this Triangle2 item)
        {
            return item.GetPoints().Average();
        }

        static public IEnumerable<Vector2> GetPoints(this Triangle2 item)
        {
            yield return item.v0;
            yield return item.v1;
            yield return item.v2;
        }
    }
}