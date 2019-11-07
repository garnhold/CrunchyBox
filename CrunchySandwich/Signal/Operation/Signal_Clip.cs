using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class Signal_Clip : Signal
    {
        [SerializeFieldEX]private float max = 0.5f;
        [SerializeFieldEX]private float min = -0.5f;

        public override float Execute(float input)
        {
            return input.BindBetween(min, max);
        }
    }
}