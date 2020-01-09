using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    public abstract class InputDeviceStickGesture_Generated_TapSequence : InputDeviceStickGesture_Generated
    {
        protected abstract IEnumerable<InputDeviceStickZone> GenerateTapStickZones();

        protected override IEnumerable<InputDeviceStickZone> GenerateStickZones()
        {
            return GenerateTapStickZones().InterleaveCapEnd(InputDeviceStickZone.Center);
        }
    }
}