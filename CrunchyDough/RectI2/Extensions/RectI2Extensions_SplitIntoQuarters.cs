using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class RectI2Extensions_SplitIntoQuarters
    {
        static public void SplitIntoQuarters(this RectI2 item, out RectI2 r1, out RectI2 r2, out RectI2 r3, out RectI2 r4)
        {
            RectI2 left;
            RectI2 right;

            item.SplitByXCenter(out left, out right);

            left.SplitByYCenter(out r1, out r2);
            right.SplitByYCenter(out r3, out r4);
        }

        static public IEnumerable<RectI2> SplitIntoQuarters(this RectI2 item)
        {
            RectI2 r1, r2, r3, r4;

            item.SplitIntoQuarters(out r1, out r2, out r3, out r4);

            yield return r1;
            yield return r2;
            yield return r3;
            yield return r4;
        }
    }
}