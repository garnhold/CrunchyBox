using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    public class Signal_EaseShape_Quad : Signal_EaseShape
    {
        public override float Execute(float input)
        {
            return EaseOperations.QuadIn(input);
        }
    }
}