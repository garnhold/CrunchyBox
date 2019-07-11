using System;

using UnityEngine;

namespace CrunchySandwich
{
    public abstract class PeriodicFunction : CustomAsset
    {
        public abstract float Execute(float input);
    }
}