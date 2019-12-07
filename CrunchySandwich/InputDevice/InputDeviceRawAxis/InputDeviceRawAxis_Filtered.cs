using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBread;

namespace CrunchySandwich
{
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