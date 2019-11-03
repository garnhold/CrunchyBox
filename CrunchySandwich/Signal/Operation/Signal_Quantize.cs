using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class Signal_Quantize : Signal
    {
        [SerializeFieldEX]private float interval = 0.25f;

        public override float Execute(float input)
        {
            return input.GetQuantizedMin(interval);
        }
    }
}