using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class Signal_Transform : Signal
    {
        [SerializeFieldEX]private float scale = 1.0f;
        [SerializeFieldEX]private float offset = 0.0f;

        public override float Execute(float input)
        {
            return input * scale + offset;
        }
    }
}