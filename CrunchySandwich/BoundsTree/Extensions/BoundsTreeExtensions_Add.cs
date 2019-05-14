using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
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