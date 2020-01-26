using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    public class Signal_LimitSlew : Signal
    {
        [SerializeFieldEX]private float max_speed = 0.1f;
        [SerializeFieldEX]private TimeType time_type = TimeType.Active;

        private float previous_output;

        public override float Execute(float input)
        {
            previous_output = previous_output.GetTowards(input, max_speed * time_type.GetDelta());

            return previous_output;
        }
    }
}