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

        private bool is_pressed;
        private bool is_released;
        private InputDeviceComponentButtonPress current_press;

        private CircularStack<InputDeviceComponentButtonPress> presses;

        public InputDeviceComponent_Button(string a)
        {
            internal_axis_name = a;

            is_pressed = false;
            is_released = false;
            current_press = null;
            presses = new CircularStack<InputDeviceComponentButtonPress>(32);
        }

        public override void Update()
        {
            is_pressed = false;
            is_released = false;

            if (Input.GetButton(internal_axis_name))
            {
                if (current_press == null)
                {
                    current_press = new InputDeviceComponentButtonPress();
                    is_pressed = true;
                }
            }
            else
            {
                if (current_press != null)
                {
                    current_press.Release();
                    presses.Advance(current_press);

                    current_press = null;
                    is_released = true;
                }
            }
        }

        public bool IsButtonDown()
        {
            if (current_press != null)
                return true;

            return false;
        }

        public bool IsButtonPressed()
        {
            return is_pressed;
        }

        public bool IsButtonReleased()
        {
            return is_released;
        }

        public InputDeviceComponentButtonPress GetCurrentButtonPress()
        {
            return current_press;
        }

        public int GetNumberRecentButtonPresses()
        {
            return presses.Count;
        }

        public IEnumerable<InputDeviceComponentButtonPress> GetRecentButtonPresses(int count)
        {
            for (int i = count - 1; i >= 0; i--)
                yield return presses[i];
        }
    }
}