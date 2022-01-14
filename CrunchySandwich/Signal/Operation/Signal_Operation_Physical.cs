using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public abstract class Signal_Operation_Physical : Signal_Operation
    {
        [SerializeFieldEX]private float max_speed = 10.0f;
        [SerializeFieldEX]private float dampning = 1.0f;
        [SerializeFieldEX]private TimeType time_type = TimeType.Active;

        private float velocity;
        private float position;

        protected abstract float Calculate(float position, float velocity, float target, float delta);

        public override float Execute(float input)
        {
            float acceleration = Calculate(position, velocity, input, time_type.GetDelta());

            velocity += acceleration * time_type.GetDelta();

            velocity = velocity
                .GetTowards(0.0f, velocity * dampning * time_type.GetDelta())
                .BindMagnitudeBelow(max_speed);

            position += velocity * time_type.GetDelta();
            return position;
        }
    }
}