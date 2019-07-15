using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [AssetClassCategory("Input")]
    public abstract class InputDeviceStickGesture : CustomAsset
    {
        public abstract ICatalog<InputDeviceStickZone> GetStickZones();
    }
}