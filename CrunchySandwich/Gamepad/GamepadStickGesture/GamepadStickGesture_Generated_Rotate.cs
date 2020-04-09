using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bread;

    public class GamepadStickGesture_Generated_Rotate : GamepadStickGesture_Generated
    {
        [SerializeField]private RotationDirection direction;
        [SerializeField]private CardinalOrdinalDirection starting;
        [SerializeField]private CardinalOrdinalDirection ending;

        protected override IEnumerable<GamepadStickZone> GenerateStickZones()
        {
            return starting.GetSequenceTo(ending, direction)
                .Convert(d => d.GetGamepadStickZone());
        }
    }
}