using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public abstract class Indicator : MonoBehaviourEX, EphemeralPrefab
    {
        public abstract void Initialize(Vector3 position, float strength);
    }
}