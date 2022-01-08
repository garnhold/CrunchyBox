using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    public class Signal_Operation_Smooth : Signal_Operation
    {
        [SerializeFieldEX]private float speed = 2.9f;
        [SerializeFieldEX]private TimeType time_type = TimeType.Active;

        private float previous_output;

        public override float Execute(float input)
        {
            previous_output = previous_output.GetInterpolate(input, speed * time_type.GetDelta());

            return previous_output;
        }
    }
}