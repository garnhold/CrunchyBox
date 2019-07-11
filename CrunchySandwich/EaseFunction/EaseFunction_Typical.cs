using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class EaseFunction_Typical : EaseFunction
    {
        [SerializeFieldEX]private EaseFunctionTransform transform;

        protected abstract float ExecuteInternal(float input);

        public override float Execute(float input)
        {
            return transform.Apply(input, ExecuteInternal);
        }
    }
}