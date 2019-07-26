using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public abstract class InputDeviceComponent_Button : InputDeviceComponent
    {
        private bool is_down;
        private bool is_pressed;
        private bool is_released;

        private bool frozen_is_down;

        private InputDeviceEventLog<bool> presses;

        protected abstract bool IsButtonDownInternal();

        protected override void FreezeInternal()
        {
            frozen_is_down = is_down;
        }

        protected override void UpdateInternal()
        {
            is_down = false;
            is_pressed = false;
            is_released = false;

            if (IsButtonDownInternal())
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

        public InputDeviceComponent_Button()
        {
            is_down = false;
            is_pressed = false;
            is_released = false;

            frozen_is_down = false;

            presses = new InputDeviceEventLog<bool>(32);
        }

        public bool IsButtonDown()
        {
            return SwitchSharedFrozen(is_down, frozen_is_down);
        }

        public bool IsButtonPressed()
        {
            return SwitchSharedExclusive(is_pressed);
        }

        public bool IsButtonReleased()
        {
            return SwitchSharedExclusive(is_released);
        }

        public InputDeviceEventHistory<bool> GetHistory()
        {
            return SwitchSharedExclusive<InputDeviceEventHistory<bool>>(
                presses,
                InputDeviceEventEmptyHistory<bool>.INSTANCE
            );
        }
    }
}