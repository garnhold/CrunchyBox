using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public class Signal_Operation_Physical_Spring : Signal_Operation_Physical
    {
        [SerializeFieldEX]private float stiffness = 10.0f;

        protected override float Calculate(float position, float velocity, float target, float delta)
        {
            return (target - position) * stiffness;
        }
    }
}