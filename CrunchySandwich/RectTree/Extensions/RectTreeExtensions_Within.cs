using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class RectTreeExtensions_Within
    {
        static public IEnumerable<T> GetItemsWithin<T>(this RectTree<T> item, Rect rect)
        {
            return item.GetItemsWithin(b => b.Overlaps(rect));
        }
    }
}