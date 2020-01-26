using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    public class Signal_EaseShape_Sine : Signal_EaseShape
    {
        public override float Execute(float input)
        {
            return EaseOperations.SineIn(input);
        }
    }
}