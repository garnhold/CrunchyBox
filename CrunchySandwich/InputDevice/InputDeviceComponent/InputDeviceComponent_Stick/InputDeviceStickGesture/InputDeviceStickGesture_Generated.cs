using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public abstract class InputDeviceStickGesture_Generated : InputDeviceStickGesture
    {
        private List<InputDeviceStickZone> zones;

        protected abstract IEnumerable<InputDeviceStickZone> GenerateStickZones();

        private void OnValidate()
        {
            zones = null;
        }

        public override ICatalog<InputDeviceStickZone> GetStickZones()
        {
            if (zones.IsEmpty())
                zones = GenerateStickZones().ToList();

            return zones;
        }
    }
}