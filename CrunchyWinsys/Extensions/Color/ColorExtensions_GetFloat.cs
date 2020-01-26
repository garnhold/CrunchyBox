using System;
using System.Drawing;

namespace Crunchy.Winsys
{
    using Dough;
    using Salt;
    using Noodle;
    using Sauce;
    
    static public class ColorExtensions_GetFloat
    {
        static public float GetRedFloat(this Color item)
        {
            return item.R.GetFloatPercent();
        }

        static public float GetGreenFloat(this Color item)
        {
            return item.G.GetFloatPercent();
        }

        static public float GetBlueFloat(this Color item)
        {
            return item.B.GetFloatPercent();
        }

        static public float GetAlphaFloat(this Color item)
        {
            return item.A.GetFloatPercent();
        }
    }
}