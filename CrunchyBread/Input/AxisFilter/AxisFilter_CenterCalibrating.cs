using System;

namespace Crunchy.Bread
{
    using Dough;
    
    public class AxisFilter_CenterCalibrating : AxisFilter
    {
        private float offset;
        private bool has_calibrated;

        public override float Filter(float value)
        {
            if (has_calibrated == false)
            {
                offset = -value;

                has_calibrated = true;
            }

            return value + offset;
        }
    }
}