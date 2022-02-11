using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Sauce;
    
    public class Mixer_Color_Simple_Normal : Mixer_Color_Simple
    {
        protected override Color MixSimple(Color src_pm, Color dst_pm, float weight)
        {
            return dst_pm.GetInterpolate(src_pm, weight * src_pm.a);
        }
    }
}