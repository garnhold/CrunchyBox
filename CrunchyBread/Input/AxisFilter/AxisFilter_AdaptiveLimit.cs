using System;

using CrunchyDough;
using CrunchyBun;

namespace CrunchyBread
{
    public class AxisFilter_AdaptiveLimit : AxisFilter
    {
        private float limit;

        public AxisFilter_AdaptiveLimit(float il)
        {
            limit = il;
        }

        public AxisFilter_AdaptiveLimit() : this(0.1f) { }

        public override float Filter(float value)
        {
            limit = limit.Max(value.GetAbs());

            return value.ConvertFromVarianceToOffset(0.0f, limit);
        }
    }
}