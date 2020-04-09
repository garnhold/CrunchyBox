using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bread;

    public class GamepadStickGesture_Generated_TapSequence_Repeated : GamepadStickGesture_Generated_TapSequence
    {
        [SerializeField]private int times;
        [SerializeField]private GamepadStickZone zone;

        protected override IEnumerable<GamepadStickZone> GenerateTapStickZones()
        {
            return zone.Repeat(times);
        }
    }
}