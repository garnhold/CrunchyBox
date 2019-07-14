using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class InputDeviceStickGesture_Generated_TapSequence : InputDeviceStickGesture_Generated
    {
        protected abstract IEnumerable<InputDeviceStickZone> GenerateTapStickZones();

        protected override IEnumerable<InputDeviceStickZone> GenerateStickZones()
        {
            return GenerateTapStickZones().InterleaveCapEnd(InputDeviceStickZone.Center);
        }
    }
}