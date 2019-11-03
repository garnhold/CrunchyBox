using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class Signal_Simulated : Signal
    {
        [SerializeFieldEX]private float maximum_distance = 5.0f;
        [SerializeFieldEX]private float dampening = 1.2f;
        [SerializeFieldEX]private float bounciness = 0.9f;

        [SerializeFieldEX]private TimeType time_type = TimeType.Active;

        private float position;
        private float velocity;

        protected abstract float CalculateAcceleration(float position, float velocity, float target);

        public override float Execute(float input)
        {
            float bottom = input - maximum_distance;
            float top = input + maximum_distance;

            if (position < bottom)
            {
                position = bottom;
                velocity *= -bounciness;
            }

            if (position > top)
            {
                position = top;
                velocity *= -bounciness;
            }

            velocity += CalculateAcceleration(position, velocity, input) * time_type.GetDelta();
            velocity -= velocity * dampening * time_type.GetDelta();

            position += velocity * time_type.GetDelta();

            return position;
        }
    }
}