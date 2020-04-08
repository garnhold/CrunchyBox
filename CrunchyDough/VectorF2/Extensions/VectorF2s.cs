using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public partial class VectorF2s
    {
        static public IEnumerable<VectorF2> Ray(VectorF2 start, VectorF2 step, int divisions)
        {
            for (int i = 0; i < divisions; i++)
                yield return start + i * step;
        }

        static public IEnumerable<VectorF2> Line(VectorF2 start, VectorF2 end, int divisions, bool include_end)
        {
            VectorF2 step;

            if (include_end)
                step = (end - start) / (divisions - 1);
            else
                step = (end - start) / divisions;

            return Ray(start, step, divisions);
        }

        static public IEnumerable<VectorF2> Range(VectorF2 start, VectorF2 end, float step, bool include_end)
        {
            float distance;
            VectorF2 direction = start.GetDirection(end, out distance);

            int divisions = (int)(distance / step).GetAbs();

            if (include_end)
                divisions++;

            return Ray(start, direction * (distance / divisions), divisions);
        }
        static public IEnumerable<VectorF2> Range(VectorF2 start, VectorF2 end, bool include_end)
        {
            return Range(start, end, 1.0f, include_end);
        }
    }
}