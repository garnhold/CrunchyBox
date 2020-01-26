using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    public class Signal_EaseShape_Quint : Signal_EaseShape
    {
        public override float Execute(float input)
        {
            return EaseOperations.QuintIn(input);
        }
    }
}