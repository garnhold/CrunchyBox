using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bread;
    
    public class GamepadStickGesture_Custom : GamepadStickGesture
    {
        [SerializeField]private List<GamepadStickZone> zones;

        public override ICatalog<GamepadStickZone> GetStickZones()
        {
            return zones;
        }
    }
}