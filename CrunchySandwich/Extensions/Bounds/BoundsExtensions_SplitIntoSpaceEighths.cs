using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class BoundsExtensions_SplitIntoSpaceEighths
    {
        static public void SplitIntoSpaceEighths(this Bounds item, out Bounds b1, out Bounds b2, out Bounds b3, out Bounds b4, out Bounds b5, out Bounds b6, out Bounds b7, out Bounds b8)
        {
            Bounds bottom;
            Bounds top;

            item.SplitByYCenter(out bottom, out top);

            bottom.SplitIntoAreaQuarters(out b1, out b2, out b3, out b4);
            top.SplitIntoAreaQuarters(out b5, out b6, out b7, out b8);
        }

        static public IEnumerable<Bounds> SplitIntoSpaceEighths(this Bounds item)
        {
            Bounds b1, b2, b3, b4, b5, b6, b7, b8;

            item.SplitIntoSpaceEighths(out b1, out b2, out b3, out b4, out b5, out b6, out b7, out b8);

            yield return b1;
            yield return b2;
            yield return b3;
            yield return b4;

            yield return b5;
            yield return b6;
            yield return b7;
            yield return b8;
        }
    }
}