using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Crunchy.Winsys
{
    using Dough;
    using Salt;
    using Noodle;
    using Bun;
    using Sauce;
    
    static public class BitmapExtensions_Surface
    {
        static public Surface<Color> GetSurface(this Bitmap item)
        {
            return new Surface_Bitmap(item);
        }
    }
}