using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bread;

    static public class GamepadActionExtensions
    {
        static public Indicator DeployIndicator(this GamepadAction item, Vector2 position, float strength)
        {
            Indicator indicator = item.GetIndicator().SpawnInstancePlanarAt(position);

            indicator.Initialize(position, strength);
            return indicator;
        }
    }
}