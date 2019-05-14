using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class RectExtensions_SplitIntoQuarters
    {
        static public void SplitIntoQuarters(this Rect item, out Rect r1, out Rect r2, out Rect r3, out Rect r4)
        {
            Rect left;
            Rect right;

            item.SplitByXCenter(out left, out right);

            left.SplitByYCenter(out r1, out r2);
            right.SplitByYCenter(out r3, out r4);
        }

        static public IEnumerable<Rect> SplitIntoQuarters(this Rect item)
        {
            Rect r1, r2, r3, r4;

            item.SplitIntoQuarters(out r1, out r2, out r3, out r4);

            yield return r1;
            yield return r2;
            yield return r3;
            yield return r4;
        }
    }
}