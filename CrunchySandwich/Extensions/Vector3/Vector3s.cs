using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class Vector3s
    {
        static public IEnumerable<Vector3> Ray(Vector3 start, Vector3 step, int divisions)
        {
            for (int i = 0; i < divisions; i++)
                yield return start + i * step;
        }

        static public IEnumerable<Vector3> Line(Vector3 start, Vector3 end, int divisions, bool include_end)
        {
            Vector3 step;

            if (include_end)
                step = (end - start) / (divisions - 1);
            else
                step = (end - start) / divisions;

            return Ray(start, step, divisions);
        }

        static public IEnumerable<Vector3> Range(Vector3 start, Vector3 end, float step, bool include_end)
        {
            float distance;
            Vector3 direction = start.GetDirection(end, out distance);

            int divisions = (int)(distance / step).GetAbs();

            if (include_end)
                divisions++;

            return Ray(start, direction * (distance / divisions), divisions);
        }
        static public IEnumerable<Vector3> Range(Vector3 start, Vector3 end, bool include_end)
        {
            return Range(start, end, 1.0f, include_end);
        }
    }
}