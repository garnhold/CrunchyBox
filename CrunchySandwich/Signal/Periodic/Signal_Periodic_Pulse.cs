using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    public class Signal_Periodic_Pulse : Signal_Periodic_Typical
    {
        [SerializeFieldEX]private float duty;

        protected override float ExecuteInternal(float input)
        {
            return Wave.Pulse(input, duty);
        }
    }
}