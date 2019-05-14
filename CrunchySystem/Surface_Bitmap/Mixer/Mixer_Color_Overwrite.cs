using System;
using System.Drawing;

using CrunchySauce;

namespace CrunchySystem
{
    public class Mixer_Color_Overwrite : Mixer<Color>
    {
        public override Color Mix(Color src, Color dst, float weight)
        {
            return dst.GetInterpolate(src, weight);
        }
    }
}