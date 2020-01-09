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
    
    static public class StreamSystemExtensions_Bitmap
    {
        static public AttemptResult AttemptReadBitmap(this StreamSystem item, string path, out Bitmap bitmap, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.AttemptRead<Bitmap>(path, delegate(Stream stream) {
                return BitmapFactory.DecodeStream(stream);
            }, out bitmap, milliseconds);
        }
        static public Bitmap ReadBitmap(this StreamSystem item, string path, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            Bitmap output;

            item.AttemptReadBitmap(path, out output, milliseconds);
            return output;
        }
    }
}