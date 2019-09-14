using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class Signal_Generator : Signal
    {
        protected abstract float Execute();

        public override float Execute(float input)
        {
            return Execute();
        }
    }
}