using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class BoundsTreeExtensions_Add
    {
        static public void AddRange<T>(this BoundsTree<T> item, IEnumerable<T> to_add)
        {
            to_add.Process(i => item.Add(i));
        }
        static public void AddRange<T>(this BoundsTree<T> item, params T[] to_add)
        {
            item.AddRange((IEnumerable<T>)to_add);
        }
    }
}