using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public abstract class Indicator : MonoBehaviourEX, EphemeralPrefab
    {
        public abstract void Initialize(Vector3 position, float strength);
    }
}