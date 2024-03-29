﻿using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public abstract class Signal_Ease : Signal
    {
        [SerializeFieldEX]private SignalEaseTransform transform;

        protected abstract float ExecuteInternal(float input);

        public override float Execute(float input)
        {
            return transform.Apply(input, ExecuteInternal);
        }
    }
}