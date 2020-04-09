using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bread;
    
    [AssetClassCategory("Input")]
    public abstract class GamepadStickGesture : CustomAsset
    {
        public abstract ICatalog<GamepadStickZone> GetStickZones();
    }
}