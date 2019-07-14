using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class InputDeviceStickGesture_Generated_TapSequence_Custom : InputDeviceStickGesture_Generated_TapSequence
    {
        [SerializeField]private List<InputDeviceStickZone> tap_zones;

        protected override IEnumerable<InputDeviceStickZone> GenerateTapStickZones()
        {
            return tap_zones;
        }
    }
}