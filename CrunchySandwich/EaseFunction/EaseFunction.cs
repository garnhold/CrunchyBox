using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class EaseFunction : CustomAsset
    {
        [SerializeField]private float low;
        [SerializeField]private float high;

        protected abstract float ExecuteInternal(float input);

        public float Execute(float input)
        {
            return ExecuteInternal(input.BindBetween(0.0f, 1.0f).ConvertFromPercentToRange(low, high));
        }
    }
}