using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class Signal_Generator_Time_ActiveGameTime : Signal_Generator_Time
    {
        protected override float GetTime()
        {
            return ActiveGameTime.GetTime();
        }
    }
}