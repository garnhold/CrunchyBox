using System;

using UnityEngine;

namespace CrunchySandwich
{
    public abstract class PeriodicFunction_Typical : PeriodicFunction
    {
        [SerializeField]private PeriodicFunctionTransform transform;

        protected abstract float ExecuteInternal(float input);

        public override float Execute(float input)
        {
            return transform.Apply(input, ExecuteInternal);
        }
    }
}