using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    public abstract class Signal_Ease_Typical : Signal_Ease
    {
        [SerializeFieldEX]private SignalEaseTransform transform;

        protected abstract float ExecuteInternal(float input);

        public override float Execute(float input)
        {
            return transform.Apply(input, ExecuteInternal);
        }
    }
}