using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    public class Signal_Periodic_Curve : Signal_Periodic_Typical
    {
        [SerializeFieldEX]private Curve curve;

        protected override float ExecuteInternal(float input)
        {
            return curve.GetLoopedValue(input);
        }
    }
}