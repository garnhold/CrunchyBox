using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    public class Signal_Operation_Quantize : Signal_Operation
    {
        [SerializeFieldEX]private float interval = 0.25f;

        public override float Execute(float input)
        {
            return input.GetQuantizedMin(interval);
        }
    }
}