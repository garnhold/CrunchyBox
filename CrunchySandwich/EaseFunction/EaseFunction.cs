using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class EaseFunction : CustomAsset
    {
        public abstract float Execute(float input);
    }
}