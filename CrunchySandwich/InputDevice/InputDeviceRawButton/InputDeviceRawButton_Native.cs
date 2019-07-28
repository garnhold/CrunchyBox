﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class InputDeviceRawButton_Native : InputDeviceRawButton
    {
        private string internal_axis_name;

        public InputDeviceRawButton_Native(string a)
        {
            internal_axis_name = a;
        }

        public override bool IsButtonDown()
        {
            return Input.GetButton(internal_axis_name);
        }
    }
}