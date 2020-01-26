using System;
using System.Drawing;

namespace Crunchy.Winsys
{
    using Dough;
    using Salt;
    using Noodle;
    using Sauce;
    
    static public class ColorExtensions
    {
        static public Color Create(float r, float g, float b, float a)
        {
            return Color.FromArgb(
                a.GetBytePercent(),
                r.GetBytePercent(),
                g.GetBytePercent(),
                b.GetBytePercent()
            );
        }
    }
}