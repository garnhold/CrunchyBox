﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class InputDeviceComponent_Stick : InputDeviceComponent
    {
        private InputDeviceRawStick stick;

        private Vector2 value;
        private float magnitude;
        private float angle_in_degrees;

        private Vector2 frozen_value;
        private float frozen_magnitude;
        private float frozen_angle_in_degrees;

        private InputDeviceEventLog<InputDeviceStickZone> stick_zones;

        protected override void FreezeInternal()
        {
            frozen_value = value;
            frozen_magnitude = magnitude;
            frozen_angle_in_degrees = angle_in_degrees;
        }

        protected override void UpdateInternal()
        {
            value = stick.GetValue();
            magnitude = value.GetMagnitude();

            if (magnitude != 0.0f)
                angle_in_degrees = value.GetAngleInDegrees();

            if (magnitude < 0.8f)
                stick_zones.LogValue(InputDeviceStickZone.Center);
            else
            {
                stick_zones.LogValue(
                    angle_in_degrees.GetDegreeAngleClosestCardinalOrdinalDirection().GetInputDeviceComponentStickZone()
                );
            }
        }

        public InputDeviceComponent_Stick(InputDeviceRawStick s)
        {
            stick = s;

            value = Vector2.zero;
            magnitude = 0.0f;
            angle_in_degrees = 0.0f;

            frozen_value = Vector2.zero;
            frozen_magnitude = 0.0f;
            frozen_angle_in_degrees = 0.0f;

            stick_zones = new InputDeviceEventLog<InputDeviceStickZone>(64);
        }

        public Vector2 GetValue()
        {
            return SwitchSharedFrozen(value, frozen_value);
        }

        public float GetMagnitude()
        {
            return SwitchSharedFrozen(magnitude, frozen_magnitude);
        }

        public float GetAngleInDegrees()
        {
            return SwitchSharedFrozen(angle_in_degrees, frozen_angle_in_degrees);
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