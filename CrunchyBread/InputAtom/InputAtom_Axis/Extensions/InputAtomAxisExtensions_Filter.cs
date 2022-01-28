using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    static public class InputAtomAxisExtensions_Filter
    {
        static public InputAtom_Axis GetWithFilter(this InputAtom_Axis item, AxisFilter filter)
        {
            return item.IfNotNull(i => new InputAtom_Axis_Filter(i, filter));
        }

        static public InputAtom_Axis GetWithDeadZone(this InputAtom_Axis item, float dead_zone)
        {
            return item.GetWithFilter(new AxisFilter_DeadZone(dead_zone));
        }
        static public InputAtom_Axis GetInverted(this InputAtom_Axis item)
        {
            return item.GetWithFilter(new AxisFilter_Invert());
        }
        static public InputAtom_Axis GetWithGeneralFilter(this InputAtom_Axis item, float dead_zone, bool invert, bool adaptive_limit = true, bool center_calibrating = false)
        {
            return item.GetWithFilter(AxisFilters.General(dead_zone, invert, adaptive_limit, center_calibrating));
        }
    }
}