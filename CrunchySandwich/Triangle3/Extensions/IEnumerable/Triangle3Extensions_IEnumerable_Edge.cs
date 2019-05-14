using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class Triangle3Extensions_IEnumerable_Edge
    {
        static public IEnumerable<Edge3> GetEdges(this IEnumerable<Triangle3> item)
        {
            return item.Convert(t => t.GetEdges()).Unique();
        }
    }
}