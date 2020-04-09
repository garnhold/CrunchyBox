using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bread;
    
    public abstract class GamepadStickGesture_Generated : GamepadStickGesture
    {
        private List<GamepadStickZone> zones;

        protected abstract IEnumerable<GamepadStickZone> GenerateStickZones();

        private void OnValidate()
        {
            zones = null;
        }

        public override ICatalog<GamepadStickZone> GetStickZones()
        {
            if (zones.IsEmpty())
                zones = GenerateStickZones().ToList();

            return zones;
        }
    }
}