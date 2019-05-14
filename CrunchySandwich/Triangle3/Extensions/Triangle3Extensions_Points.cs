using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace CrunchySandwich
{
    static public class Triangle3Extensions_Points
    {
        static public IEnumerable<Vector3> GetPoints(this Triangle3 item)
        {
            yield return item.v0;
            yield return item.v1;
            yield return item.v2;
        }
    }
}