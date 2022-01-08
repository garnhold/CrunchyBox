using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public class Signal_Periodic_Skew : Signal_Periodic
    {
        [SerializeField] private SkewWaveType type;
        [SerializeField][Range(0.0f, 1.0f)]private float skew;

        protected override float ExecuteInternal(float input)
        {
            return type.Calculate(input, skew);
        }
    }
}