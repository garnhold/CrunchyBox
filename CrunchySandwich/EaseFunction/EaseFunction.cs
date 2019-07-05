using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class EaseFunction : CustomAsset
    {
        [SerializeFieldEX]private FloatRange domain = new FloatRange(0.0f, 1.0f);
        [SerializeFieldEX]private FloatRange range = new FloatRange(0.0f, 1.0f);

        protected abstract float ExecuteInternal(float input);

        public float Execute(float input)
        {
            return ExecuteInternal(input.ConvertFromRangeToPercent(domain).BindPercent())
                .BindPercent().ConvertFromPercentToRange(range);
        }
    }
}