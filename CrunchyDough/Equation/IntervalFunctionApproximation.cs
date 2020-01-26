using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    public class IntervalFunctionApproximation
    {
        private float segment_start;
        private float segment_end;
        private Operation<float, float> operation;

        private FunctionTableSegment segment;

        public IntervalFunctionApproximation(float s, float e, int d, Operation<float, float> o)
        {
            segment_start = s;
            segment_end = e;
            operation = o;

            segment = new FunctionTableSegment(segment_start, segment_end, d, operation);
        }

        public float Evaluate(float x)
        {
            if(x >= segment_start && x < segment_end)
                return segment.Evaluate(x);

            return operation(x);
        }
    }
}