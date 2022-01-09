using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public class Signal_Generator_Drifting_Random : Signal_Generator_Drifting
    {
        [SerializeFieldEX]private FloatRange interval_range;

        private float value;

        private float interval_position;
        private float interval_length;

        private void Next()
        {
            value = RandFloat.GetOffset(1.0f);

            interval_position = 0.0f;
            interval_length = RandFloat.GetBetween(interval_range);
        }

        protected override float ExecuteDrifted(float time, float delta)
        {
            interval_position += delta;
            if (interval_position >= interval_length)
                Next();

            return value;
        }
    }
}