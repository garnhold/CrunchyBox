using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public class Signal_Ease_Basic : Signal_Ease
    {
        [SerializeField] private BasicEaseType type;

        protected override float ExecuteInternal(float input)
        {
            return type.Calculate(input);
        }
    }
}