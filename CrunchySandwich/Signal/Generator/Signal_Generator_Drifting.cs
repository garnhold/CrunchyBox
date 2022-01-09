using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public abstract class Signal_Generator_Drifting : Signal_Generator
    {
        [SerializeFieldEX]private float drift;

        private float drifted_time;

        protected abstract float ExecuteDrifted(float time, float delta);

        protected override float Execute(float time, float delta)
        {
            float drifted_delta = RandFloat.GetVariance(1.0f, drift) * delta;

            drifted_time += drifted_delta;
            return ExecuteDrifted(drifted_time, drifted_delta);
        }
    }
}