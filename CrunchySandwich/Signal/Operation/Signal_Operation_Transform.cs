using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public class Signal_Operation_Transform : Signal_Operation
    {
        [SerializeFieldEX]private float scale = 1.0f;
        [SerializeFieldEX]private float offset = 0.0f;

        public override float Execute(float input)
        {
            return input * scale + offset;
        }
    }
}