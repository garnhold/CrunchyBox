using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    [AssetClassCategory("Input")]
    public abstract class InputDeviceStickGesture : CustomAsset
    {
        public abstract ICatalog<InputDeviceStickZone> GetStickZones();
    }
}