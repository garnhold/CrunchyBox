using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public class Signal_Operation_Physical_Gravity : Signal_Operation_Physical
    {
        [SerializeFieldEX]private float gravity = 10.0f;

        protected override float Calculate(float position, float velocity, float target, float delta)
        {
            if (position > target)
                return -gravity;

            return gravity;
        }
    }
}