using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class Signal_Generator_Timer : Signal_Generator
    {
        [SerializeFieldEX]private GameTimer timer;

        public Signal_Generator_Timer()
        {
            timer.Start();
        }

        protected override float Execute()
        {
            return timer.GetTimeElapsedInPercent().BindPercent();
        }
    }
}