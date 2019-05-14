using System;

using UnityEngine;

using CrunchySauce;

namespace CrunchySandwich
{
    public class Mixer_Color_Simple_Overwrite : Mixer_Color_Simple
    {
        protected override Color MixSimple(Color src_pm, Color dst_pm, float weight)
        {
            return dst_pm.GetInterpolate(src_pm, weight);
        }
    }
}