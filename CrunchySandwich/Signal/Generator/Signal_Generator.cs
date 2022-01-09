using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public abstract class Signal_Generator : Signal
    {
        [SerializeFieldEX]private TimeType time_type;

        private float previous_time;

        protected abstract float Execute(float time, float delta);

        public Signal_Generator()
        {
            previous_time = time_type.GetTime();
        }

        public override float Execute(float input)
        {
            float current_time = time_type.GetTime();

            float generated = Execute(
                current_time, 
                (current_time - previous_time).BindBelow(1.0f)
            );

            previous_time = current_time;
            return generated;
        }
    }
}