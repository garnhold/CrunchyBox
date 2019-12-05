using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class InputDeviceRawAxis_Native : InputDeviceRawAxis
    {
        private string internal_axis_name;
        private float dead_zone;

        private bool has_calibrated;

        private float center;
        private float center_left;
        private float center_right;

        private float left;
        private float right;

        private void Calibrate()
        {
            float raw_value = GetRawValue();

            center = raw_value;
            center_left = center - dead_zone;
            center_right = center + dead_zone;

            left = center_left - 0.10f;
            right = center_right + 0.10f;

            has_calibrated = true;
        }

        private float GetRawValue()
        {
            return Input.GetAxisRaw(internal_axis_name);
        }

        public InputDeviceRawAxis_Native(string a, float d)
        {
            internal_axis_name = a;
            dead_zone = d;

            has_calibrated = false;
        }

        public InputDeviceRawAxis_Native(string a) : this(a, 0.0f) { }

        public override float GetValue()
        {
            float raw_value = GetRawValue();

            if (has_calibrated == false)
                Calibrate();

            if (raw_value < left)
                left = raw_value;

            if (raw_value > right)
                right = raw_value;

            if (raw_value < center_left)
                return raw_value.ConvertFromRangeToRange(left, center_left, -1.0f, 0.0f);

            if (raw_value > center_right)
                return raw_value.ConvertFromRangeToRange(center_right, right, 0.0f, 1.0f);

            return 0.0f;
        }
    }
}