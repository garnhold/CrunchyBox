using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    static public class RectF2Extensions_SplitIntoQuarters
    {
        static public void SplitIntoQuarters(this RectF2 item, out RectF2 r1, out RectF2 r2, out RectF2 r3, out RectF2 r4)
        {
            RectF2 left;
            RectF2 right;

            item.SplitByXCenter(out left, out right);

            left.SplitByYCenter(out r1, out r2);
            right.SplitByYCenter(out r3, out r4);
        }

        static public IEnumerable<RectF2> SplitIntoQuarters(this RectF2 item)
        {
            RectF2 r1, r2, r3, r4;

            item.SplitIntoQuarters(out r1, out r2, out r3, out r4);

            yield return r1;
            yield return r2;
            yield return r3;
            yield return r4;
        }
    }
}