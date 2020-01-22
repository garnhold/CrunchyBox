using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public class InputDeviceRawAxis_ButtonPair : InputDeviceRawAxis
    {
        private InputDeviceRawButton negative_button;
        private InputDeviceRawButton positive_button;

        public InputDeviceRawAxis_ButtonPair(InputDeviceRawButton nb, InputDeviceRawButton pb)
        {
            negative_button = nb;
            positive_button = pb;
        }

        public override float UpdateValue()
        {
            return negative_button.UpdateIsButtonDown().ConvertBool(-1.0f) +
                positive_button.UpdateIsButtonDown().ConvertBool(1.0f);
        }
    }
}