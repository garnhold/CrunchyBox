using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class InputDeviceComponent_Button : InputDeviceComponent
    {
        private string internal_axis_name;

        private bool is_down;
        private bool is_pressed;
        private bool is_released;

        private InputDeviceEventLog<bool> presses;

        public InputDeviceComponent_Button(string a)
        {
            internal_axis_name = a;

            is_down = false;
            is_pressed = false;
            is_released = false;

            presses = new InputDeviceEventLog<bool>(32);
        }

        public override void Update()
        {
            is_down = false;
            is_pressed = false;
            is_released = false;

            if (Input.GetButton(internal_axis_name))
            {
                if (presses.LogValue(true))
                    is_pressed = true;

                is_down = true;
            }
            else
            {
                if (presses.LogValue(false))
                    is_released = true;
            }
        }

        public bool IsButtonDown()
        {
            return is_down;
        }

        public bool IsButtonPressed()
        {
            return is_pressed;
        }

        public bool IsButtonReleased()
        {
            return is_released;
        }

        public InputDeviceEventHistory<bool> GetHistory()
        {
            return presses;
        }
    }
}