using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    public class Signal_Ease_InstantAtStart : Signal_Ease_Typical
    {
        protected override float ExecuteInternal(float input)
        {
            return EaseOperations.InstantAtStart(input);
        }
    }
}