using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class Signal_EaseShape_Quad : Signal_EaseShape
    {
        public override float Execute(float input)
        {
            return EaseOperations.QuadIn(input);
        }
    }
}