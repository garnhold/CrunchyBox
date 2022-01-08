using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public class Signal_Periodic_Basic : Signal_Periodic
    {
        [SerializeField] private BasicWaveType type;

        protected override float ExecuteInternal(float input)
        {
            return type.Calculate(input);
        }
    }
}