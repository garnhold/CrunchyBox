using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class BoundsExtensions_SplitIntoAreaQuarters
    {
        static public void SplitIntoAreaQuarters(this Bounds item, out Bounds b1, out Bounds b2, out Bounds b3, out Bounds b4)
        {
            Bounds left;
            Bounds right;

            item.SplitByXCenter(out left, out right);

            left.SplitByZCenter(out b1, out b2);
            right.SplitByZCenter(out b3, out b4);
        }

        static public IEnumerable<Bounds> SplitIntoAreaQuarters(this Bounds item)
        {
            Bounds b1, b2, b3, b4;

            item.SplitIntoAreaQuarters(out b1, out b2, out b3, out b4);

            yield return b1;
            yield return b2;
            yield return b3;
            yield return b4;
        }
    }
}