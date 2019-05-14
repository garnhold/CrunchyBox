using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class BoundsTreeExtensions_Within
    {
        static public IEnumerable<T> GetItemsWithin<T>(this BoundsTree<T> item, Bounds bounds)
        {
            return item.GetItemsWithin(b => b.Intersects(bounds));
        }

        static public IEnumerable<T> GetItemsWithin<T>(this BoundsTree<T> item, Plane plane)
        {
            return item.GetItemsWithin(b => b.IntersectsPlane(plane));
        }
    }
}