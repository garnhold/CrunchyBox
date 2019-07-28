﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
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
            );
        }
    }
}