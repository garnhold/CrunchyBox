using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class Signal_Generator_Time : Signal_Generator
    {
        [SerializeFieldEX]private bool use_random_offset;

        private float random_offset;

        protected abstract float GetTime();

        public Signal_Generator_Time()
        {
            random_offset = RandFloat.GetMagnitude(3600.0f);
        }

        protected override float Execute()
        {
            if (use_random_offset)
                return GetTime() + random_offset;

            return GetTime();
        }
    }
}