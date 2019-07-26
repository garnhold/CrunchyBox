﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class InputDeviceStickGesture_Generated_Rotate : InputDeviceStickGesture_Generated
    {
        [SerializeField]private RotationDirection direction;
        [SerializeField]private CardinalOrdinalDirection starting;
        [SerializeField]private CardinalOrdinalDirection ending;

        protected override IEnumerable<InputDeviceStickZone> GenerateStickZones()
        {
            return starting.GetSequenceTo(ending, direction)
                .Convert(d => d.GetInputDeviceComponentStickZone());
        }
    }
}