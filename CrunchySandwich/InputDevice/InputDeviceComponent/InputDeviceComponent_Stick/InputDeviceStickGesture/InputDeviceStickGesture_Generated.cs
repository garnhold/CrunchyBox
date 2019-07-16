using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public abstract class InputDeviceStickGesture_Generated : InputDeviceStickGesture
    {
        private List<InputDeviceStickZone> zones;

        protected abstract IEnumerable<InputDeviceStickZone> GenerateStickZones();

        public override ICatalog<InputDeviceStickZone> GetStickZones()
        {
            if (zones.IsEmpty())
                zones = GenerateStickZones().ToList();

            return zones;
        }
    }
}