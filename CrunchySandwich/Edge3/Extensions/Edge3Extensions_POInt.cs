using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Edge3Extensions_Point
    {
        static public IEnumerable<Vector3> GetPoints(this Edge3 item)
        {
            yield return item.v0;
            yield return item.v1;
        }
    }
}