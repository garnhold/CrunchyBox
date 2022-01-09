using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public class Signal_Generator_RelativeTime : Signal_Generator
    {
        [SerializeFieldEX]private float variance = 0.0f;

        private float total_time;

        protected override float Execute(float time, float delta)
        {
            total_time += RandFloat.GetVariance(1.0f, variance) * delta;

            return total_time;
        }
    }
}