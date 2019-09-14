using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class Signal_Ease_InstantAtEnd : Signal_Ease_Typical
    {
        protected override float ExecuteInternal(float input)
        {
            return EaseOperations.InstantAtEnd(input);
        }
    }
}