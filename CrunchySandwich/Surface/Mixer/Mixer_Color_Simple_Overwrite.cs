using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Sauce;
    
    public class Mixer_Color_Simple_Overwrite : Mixer_Color_Simple
    {
        protected override Color MixSimple(Color src_pm, Color dst_pm, float weight)
        {
            return dst_pm.GetInterpolate(src_pm, weight);
        }
    }
}