using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class PeriodicFunction_RampEase : PeriodicFunction
    {
        [SerializeField]private PeriodicFunctionTransform transform;
        [SerializeField]private EaseFunction function;

        public override float Execute(float input)
        {
            return function.Execute(transform.Apply(input, Wave.Ramp));
        }
    }
}