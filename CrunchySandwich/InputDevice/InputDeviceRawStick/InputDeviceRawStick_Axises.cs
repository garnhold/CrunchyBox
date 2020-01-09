using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public class InputDeviceRawStick_Axises : InputDeviceRawStick
    {
        private InputDeviceRawAxis horizontal_axis;
        private InputDeviceRawAxis vertical_axis;

        public InputDeviceRawStick_Axises(InputDeviceRawAxis h, InputDeviceRawAxis v)
        {
            horizontal_axis = h;
            vertical_axis = v;
        }

        public override Vector2 GetValue()
        {
            return new Vector2(
                horizontal_axis.GetValue(),
                vertical_axis.GetValue()
            ).BindMagnitudeBelow(1.0f);
        }
    }
}