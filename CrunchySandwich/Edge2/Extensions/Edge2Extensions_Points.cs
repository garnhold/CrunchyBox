using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Edge2Extensions_Points
    {
        static public IEnumerable<Vector2> GetPoints(this Edge2 item)
        {
            yield return item.v0;
            yield return item.v1;
        }
    }
}