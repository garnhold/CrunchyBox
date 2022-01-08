using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    public abstract class Signal_Periodic : Signal
    {
        [SerializeFieldEX] private SignalPeriodicTransform transform;

        protected abstract float ExecuteInternal(float input);

        public override float Execute(float input)
        {
            return transform.Apply(input, ExecuteInternal);
        }
    }
}