using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Sauce;
    
    public class Mixer_Color_Simple_Normal : Mixer_Color_Simple
    {
        protected override Color MixSimple(Color src_pm, Color dst_pm, float weight)
        {
            src_pm.a *= weight;

            return src_pm + dst_pm * (1.0f - src_pm.a);
        }
    }
}