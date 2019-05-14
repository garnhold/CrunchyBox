using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    public class PeriodicFunctionApproximation
    {
        private FunctionTableSegment segment;

        public PeriodicFunctionApproximation(float p, int d, Operation<float, float> o)
        {
            segment = new FunctionTableSegment(0.0f, p, d, o);
        }

        public float Evaluate(float x)
        {
            return segment.Evaluate(x);
        }
    }
}