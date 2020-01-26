using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Crunchy.Winsys
{
    using Dough;
    using Salt;
    using Noodle;
    using Sauce;
    
    static public class BitmapExtensions_Index
    {
        static public bool IsIndexValid(this Bitmap item, int x, int y)
        {
            if (item != null)
            {
                if (x >= 0 && x < item.Width)
                {
                    if (y >= 0 && y < item.Height)
                        return true;
                }
            }

            return false;
        }
    }
}