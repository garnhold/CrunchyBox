using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class Signal_Generator : Signal
    {
        [SerializeFieldEX][PolymorphicField]private Signal signal;

        protected abstract float Execute();

        public override float Execute(float input)
        {
            float generated = Execute();

            if(signal != null)
                return signal.Execute(generated);

            return generated;
        }
    }
}