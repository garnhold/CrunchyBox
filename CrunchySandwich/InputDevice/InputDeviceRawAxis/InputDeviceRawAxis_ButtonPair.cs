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

        public override float GetValue()
        {
            if (negative_button.IsButtonDown())
            {
                if (positive_button.IsButtonDown() == false)
                    return -1.0f;
            }
            else
            {
                if (positive_button.IsButtonDown())
                    return 1.0f;
            }

            return 0.0f;
        }
    }
}