using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public class Signal_Generator_Drifting_Burst : Signal_Generator_Drifting
    {
        [SerializeFieldEX]private FloatRange on_interval_range;
        [SerializeFieldEX]private FloatRange off_interval_range;

        private bool is_on;
        private float interval_length;
        private float interval_total_time;

        private void Next()
        {
            is_on = is_on.GetFlipped();

            interval_length = is_on.ConvertBool(
                () => RandFloat.GetBetween(on_interval_range),
                () => RandFloat.GetBetween(off_interval_range)
            );
                
            interval_total_time = 0.0f;
        }

        protected override float ExecuteDrifted(float time, float delta)
        {
            interval_total_time += delta;
            if (interval_total_time >= interval_length)
                Next();

            return is_on.ConvertBool(
                () => (interval_total_time / interval_length).ConvertFromPercentToOffset(),
                () => -1.0f
            );
        }
    }
}