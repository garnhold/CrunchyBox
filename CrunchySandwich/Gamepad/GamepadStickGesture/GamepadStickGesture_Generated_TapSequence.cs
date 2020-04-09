using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bread;

    public abstract class GamepadStickGesture_Generated_TapSequence : GamepadStickGesture_Generated
    {
        protected abstract IEnumerable<GamepadStickZone> GenerateTapStickZones();

        protected override IEnumerable<GamepadStickZone> GenerateStickZones()
        {
            return GenerateTapStickZones().InterleaveCapEnd(GamepadStickZone.Center);
        }
    }
}