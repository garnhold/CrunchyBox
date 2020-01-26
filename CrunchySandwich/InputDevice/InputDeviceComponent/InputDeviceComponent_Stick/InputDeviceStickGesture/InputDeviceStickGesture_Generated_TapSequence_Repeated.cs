using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    public class InputDeviceStickGesture_Generated_TapSequence_Repeated : InputDeviceStickGesture_Generated_TapSequence
    {
        [SerializeField]private int times;
        [SerializeField]private InputDeviceStickZone zone;

        protected override IEnumerable<InputDeviceStickZone> GenerateTapStickZones()
        {
            return zone.Repeat(times);
        }
    }
}