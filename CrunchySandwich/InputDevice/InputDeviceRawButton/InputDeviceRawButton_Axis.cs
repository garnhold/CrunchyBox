using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public class InputDeviceRawButton_Axis : InputDeviceRawButton
    {
        private InputDeviceRawAxis axis;

        private float value;
        private float tolerance;

        public InputDeviceRawButton_Axis(InputDeviceRawAxis a, float v, float t)
        {
            axis = a;

            value = v;
            tolerance = t;
        }

        public override bool UpdateIsButtonDown()
        {
            if (axis.UpdateValue().IsApproximatelyEqualTo(value, tolerance))
                return true;

            return false;
        }
    }
}