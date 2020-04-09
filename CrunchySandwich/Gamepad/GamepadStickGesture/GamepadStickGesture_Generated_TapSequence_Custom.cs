using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bread;

    public class GamepadStickGesture_Generated_TapSequence_Custom : GamepadStickGesture_Generated_TapSequence
    {
        [SerializeField]private List<GamepadStickZone> tap_zones;

        protected override IEnumerable<GamepadStickZone> GenerateTapStickZones()
        {
            return tap_zones;
        }
    }
}