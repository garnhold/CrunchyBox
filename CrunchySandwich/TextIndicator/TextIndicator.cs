using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public abstract class TextIndicator : MonoBehaviourEX, EphemeralPrefab
    {
        public abstract void Initialize(Vector3 position, string text, float strength);
    }
}