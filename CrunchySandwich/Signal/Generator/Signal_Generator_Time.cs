using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public class Signal_Generator_Time : Signal_Generator
    {
        [SerializeFieldEX]private bool use_random_offset;

        private float random_offset;

        public Signal_Generator_Time()
        {
            random_offset = RandFloat.GetMagnitude(3600.0f);
        }

        protected override float Execute(float time, float delta)
        {
            if (use_random_offset)
                return time + random_offset;

            return time;
        }
    }
}