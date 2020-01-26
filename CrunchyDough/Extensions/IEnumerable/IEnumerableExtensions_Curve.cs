using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class IEnumerableExtensions_Curve
    {
        static public IEnumerable<VectorF2> InferCurveByInterval(this IEnumerable<float> item, float x, float x_interval)
        {
            foreach (float value in item)
            {
                yield return new VectorF2(x, value);

                x += x_interval;
            }
        }
    }
}