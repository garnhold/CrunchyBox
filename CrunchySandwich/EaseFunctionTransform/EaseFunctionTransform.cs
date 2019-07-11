using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [Serializable]
    public class EaseFunctionTransform
    {
        [SerializeFieldEX]private FloatRange domain = new FloatRange(0.0f, 1.0f);
        [SerializeFieldEX]private FloatRange range = new FloatRange(0.0f, 1.0f);

        public float Apply(float input, Operation<float, float> operation)
        {
            return operation(input.ConvertFromRangeToPercent(domain).BindPercent())
                .BindPercent().ConvertFromPercentToRange(range);
        }
    }
}