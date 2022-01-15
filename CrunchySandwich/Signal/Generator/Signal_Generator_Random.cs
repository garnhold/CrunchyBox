using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public class Signal_Generator_Random : Signal_Generator
    {
        [SerializeFieldEX]private FloatRange value_range = new FloatRange(-1.0f, 1.0f);
        [SerializeFieldEX]private FloatRange interval_range = new FloatRange(0.4f, 1.2f);

        private float value;

        private float interval_position;
        private float interval_length;

        private void Next()
        {
            value = RandFloat.GetBetween(value_range);

            interval_position = 0.0f;
            interval_length = RandFloat.GetBetween(interval_range);
        }

        protected override float Execute(float time, float delta)
        {
            interval_position += delta;
            if (interval_position >= interval_length)
                Next();

            return value;
        }
    }
}