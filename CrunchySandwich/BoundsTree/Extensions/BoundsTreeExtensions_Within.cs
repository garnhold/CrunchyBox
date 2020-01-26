using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class BoundsTreeExtensions_Within
    {
        static public IEnumerable<T> GetItemsWithin<T>(this BoundsTree<T> item, Bounds bounds)
        {
            return item.GetItemsWithin(b => b.IsIntersecting(bounds));
        }

        static public IEnumerable<T> GetItemsWithin<T>(this BoundsTree<T> item, Plane plane)
        {
            return item.GetItemsWithin(b => b.IsIntersecting(plane));
        }
    }
}