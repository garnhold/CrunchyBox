using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bread;
    
    public class InputDeviceRawAxis_Filtered : InputDeviceRawAxis
    {
        private InputDeviceRawAxis axis;
        private AxisFilter filter;

        public InputDeviceRawAxis_Filtered(InputDeviceRawAxis a, AxisFilter f)
        {
            axis = a;
            filter = f;
        }

        public override float UpdateValue()
        {
            return filter.Filter(axis.UpdateValue());
        }
    }
}