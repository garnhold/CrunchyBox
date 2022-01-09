using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public class Signal_Generator_Drifting_Time : Signal_Generator_Drifting
    {
        protected override float ExecuteDrifted(float time, float delta)
        {
            return time;
        }
    }
}