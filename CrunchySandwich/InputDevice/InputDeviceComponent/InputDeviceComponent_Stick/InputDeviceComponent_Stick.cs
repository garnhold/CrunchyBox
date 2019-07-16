using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class InputDeviceComponent_Stick : InputDeviceComponent
    {
        private string horizontal_internal_axis_name;
        private string vertical_internal_axis_name;

        private Vector2 value;
        private float angle_in_degrees;
        private float magnitude;

        private Vector2 frozen_value;
        private float frozen_angle_in_degrees;
        private float frozen_magnitude;

        private InputDeviceEventLog<InputDeviceStickZone> stick_zones;

        protected override void FreezeInternal()
        {
            frozen_value = value;
            frozen_angle_in_degrees = angle_in_degrees;
            frozen_magnitude = magnitude;
        }

        protected override void UpdateInternal()
        {
            value = new Vector2(Input.GetAxis(horizontal_internal_axis_name), Input.GetAxis(vertical_internal_axis_name));
            angle_in_degrees = value.GetAngleInDegrees();
            magnitude = value.GetMagnitude();

            if (magnitude < 0.4f)
                stick_zones.LogValue(InputDeviceStickZone.Center);
            else
            {
                stick_zones.LogValue(
                    angle_in_degrees.GetDegreeAngleClosestCardinalOrdinalDirection().GetInputDeviceComponentStickZone()
                );
            }
        }

        public InputDeviceComponent_Stick(string ha, string va)
        {
            horizontal_internal_axis_name = ha;
            vertical_internal_axis_name = va;

            value = Vector2.zero;
            angle_in_degrees = 0.0f;
            magnitude = 0.0f;

            frozen_value = Vector2.zero;
            frozen_angle_in_degrees = 0.0f;
            frozen_magnitude = 0.0f;

            stick_zones = new InputDeviceEventLog<InputDeviceStickZone>(64);
        }

        public Vector2 GetValue()
        {
            return SwitchSharedFrozen(value, frozen_value);
        }

        public float GetAngleInDegrees()
        {
            return SwitchSharedFrozen(angle_in_degrees, frozen_angle_in_degrees);
        }

        public float GetMagnitude()
        {
            return SwitchSharedFrozen(magnitude, frozen_magnitude);
        }

        public InputDeviceEventHistory<InputDeviceStickZone> GetHistory()
        {
            return SwitchSharedExclusive<InputDeviceEventHistory<InputDeviceStickZone>>(
                stick_zones,
                InputDeviceEventEmptyHistory<InputDeviceStickZone>.INSTANCE
            );
        }
    }
}