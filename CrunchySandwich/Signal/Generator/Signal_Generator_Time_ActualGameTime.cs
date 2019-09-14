using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class Signal_Generator_Time_ActualGameTime : Signal_Generator_Time
    {
        protected override float GetTime()
        {
            return ActualGameTime.GetTime();
        }
    }
}