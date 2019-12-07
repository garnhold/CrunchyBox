using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    public class FloatChoreographyKeyFrame
    {
        private float start;
        private float value;

        private EaseOperation ease_operation;

        public FloatChoreographyKeyFrame(float s, float v, EaseOperation e)
        {
            start = s;
            value = v;

            ease_operation = e;
        }

        public float Evaluate(float x, FloatChoreographyKeyFrame next_point)
        {
            return ease_operation.Evaluate(x, start, next_point.start, value, next_point.value);
        }

        public float GetStart()
        {
            return start;
        }

        public float GetValue()
        {
            return value;
        }
    }
}