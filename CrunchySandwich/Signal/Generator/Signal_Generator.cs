using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public abstract class Signal_Generator : Signal
    {
        [SerializeFieldEX]private TimeType time_type;
        [SerializeFieldEX][PolymorphicField]private Signal signal;

        private float previous_time;

        protected abstract float Execute(float time, float delta);

        public Signal_Generator()
        {
            previous_time = time_type.GetTime();
        }

        public override float Execute(float input)
        {
            float current_time = time_type.GetTime();
            float generated = Execute(current_time, current_time - previous_time);

            previous_time = current_time;

            if(signal != null)
                return signal.Execute(generated);

            return generated;
        }
    }
}