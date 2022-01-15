using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public abstract class Signal_Generator_Drifting : Signal_Generator
    {
        [SerializeFieldEX][Range(0.0f, 1.0f)]private float drift = 0.1f;

        private float time_multiplier;
        private GameTimer drift_timer;

        private float drifted_time;

        protected abstract float ExecuteDrifted(float time, float delta);

        protected override float Execute(float time, float delta)
        {
            if (drift_timer.Repeat())
            {
                time_multiplier = RandFloat.GetVariance(1.0f, drift);
                drift_timer.RestartSetDurationInSeconds(RandFloat.GetBetween(0.100f, 0.250f));
            }

            float drifted_delta = time_multiplier * delta;

            drifted_time += drifted_delta;
            return ExecuteDrifted(drifted_time, drifted_delta);
        }

        public Signal_Generator_Drifting()
        {
            drift_timer = new GameTimer(0.0f, TimeType.Actual).StartAndGet();
        }
    }
}