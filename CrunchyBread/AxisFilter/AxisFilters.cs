using System;

namespace Crunchy.Bread
{
    using Dough;
    
    static public class AxisFilters
    {
        static public AxisFilter General(float dead_zone, bool invert, bool adaptive_limit = false, bool center_calibrating = false)
        {
            return new AxisFilter_Series(
                Enumerable.New<AxisFilter>(
                    new AxisFilter_DeadZone(dead_zone)
                )
                .AppendIf(center_calibrating, () => new AxisFilter_CenterCalibrating())
                .AppendIf(invert, () => new AxisFilter_Invert())
                .AppendIf(adaptive_limit, () => new AxisFilter_AdaptiveLimit())
            );
        }
    }
}