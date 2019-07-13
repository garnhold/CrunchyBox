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

        private InputDeviceEventLog<InputDeviceStickZone> stick_zones;

        public InputDeviceComponent_Stick(string ha, string va)
        {
            horizontal_internal_axis_name = ha;
            vertical_internal_axis_name = va;

            stick_zones = new InputDeviceEventLog<InputDeviceStickZone>(64);
        }

        public override void Update()
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

        public Vector2 GetValue()
        {
            return value;
        }

        public float GetAngleInDegrees()
        {
            return angle_in_degrees;
        }

        public float GetMagnitude()
        {
            return magnitude;
        }

        public InputDeviceEventHistory<InputDeviceStickZone> GetHistory()
        {
            return stick_zones;
        }
    }
}