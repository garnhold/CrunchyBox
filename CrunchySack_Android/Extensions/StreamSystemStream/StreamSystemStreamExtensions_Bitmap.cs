using System;
using System.IO;

using Android;
using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;

namespace Crunchy.Sack_Android
{
    using Dough;
    using Sack;
    
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