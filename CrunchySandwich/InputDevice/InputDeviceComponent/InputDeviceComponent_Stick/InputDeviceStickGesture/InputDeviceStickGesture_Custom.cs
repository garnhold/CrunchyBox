using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public class InputDeviceStickGesture_Custom : InputDeviceStickGesture
    {
        [SerializeField]private List<InputDeviceStickZone> zones;

        public override ICatalog<InputDeviceStickZone> GetStickZones()
        {
            return zones;
        }
    }
}