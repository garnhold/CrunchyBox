using System;

using UnityEngine;

namespace CrunchySandwich
{
    public abstract class Signal_Periodic_Typical : Signal_Periodic
    {
        [SerializeFieldEX]private SignalPeriodicTransform transform;

        protected abstract float ExecuteInternal(float input);

        public override float Execute(float input)
        {
            return transform.Apply(input, ExecuteInternal);
        }
    }
}