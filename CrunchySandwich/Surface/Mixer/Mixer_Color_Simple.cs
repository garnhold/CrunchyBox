using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Sauce;
    
    public abstract class Mixer_Color_Simple : Mixer_Color
    {
        protected abstract Color MixSimple(Color src_pm, Color dst_pm, float weight);

        public override Color Mix(Color src, Color dst, float weight)
        {
            return MixSimple(src.ConvertStraightToPremultiplied(), dst.ConvertStraightToPremultiplied(), weight)
                .ConvertPremultipliedToStraight();
        }
    }
}