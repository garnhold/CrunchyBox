using System;
using System.IO;

using System.Windows;
using System.Drawing;

namespace Crunchy.Winsys
{
    using Dough;
    
    static public class StreamSystemStreamExtensions_Bitmap
    {
        static public AttemptResult AttemptReadBitmap(this StreamSystemStream item, out Bitmap bitmap, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().AttemptReadBitmap(item.GetPath(), out bitmap, milliseconds);
        }
        static public Bitmap ReadBitmap(this StreamSystemStream item, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.GetStreamSystem().ReadBitmap(item.GetPath(), milliseconds);
        }
    }
}