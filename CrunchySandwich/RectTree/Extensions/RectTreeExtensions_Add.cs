using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class RectTreeExtensions_Add
    {
        static public void AddRange<T>(this RectTree<T> item, IEnumerable<T> to_add)
        {
            to_add.Process(i => item.Add(i));
        }
        static public void AddRange<T>(this RectTree<T> item, params T[] to_add)
        {
            item.AddRange((IEnumerable<T>)to_add);
        }
    }
}