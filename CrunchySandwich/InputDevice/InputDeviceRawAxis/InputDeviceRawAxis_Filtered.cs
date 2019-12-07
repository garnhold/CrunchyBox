using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bread;
    
    public abstract class InputDeviceRawAxis_Filtered : InputDeviceRawAxis
    {
        private AxisFilter filter;

        protected abstract float GetRawValue();

        public InputDeviceRawAxis_Filtered(AxisFilter f)
        {
            filter = f;
        }

        public override float GetValue()
        {
            return filter.Filter(GetRawValue());
        }
    }
}