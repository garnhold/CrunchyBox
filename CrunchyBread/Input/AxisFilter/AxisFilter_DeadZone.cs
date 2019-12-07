using System;

using CrunchyDough;
using CrunchyBun;

namespace CrunchyBread
{
    public class AxisFilter_DeadZone : AxisFilter
    {
        private float lower_bound;
        private float upper_bound;

        public AxisFilter_DeadZone(float r)
        {
            lower_bound = -r;
            upper_bound = r;
        }

        public override float Filter(float value)
        {
            if (value < lower_bound)
                return value.ConvertFromRangeToRange(-1.0f, lower_bound, -1.0f, 0.0f);

            if (value > upper_bound)
                return value.ConvertFromRangeToRange(upper_bound, 1.0f, 0.0f, 1.0f);

            return 0.0f;
        }
    }
}