using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    public class Signal_Operation_Clip : Signal_Operation
    {
        [SerializeFieldEX]private float max = 0.5f;
        [SerializeFieldEX]private float min = -0.5f;

        public override float Execute(float input)
        {
            return input.BindBetween(min, max);
        }
    }
}