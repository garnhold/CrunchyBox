using System;
using System.IO;

using System.Windows;
using System.Drawing;

using CrunchyDough;

namespace CrunchySystem
{
    static public class StreamSystemExtensions_Bitmap
    {
        static public AttemptResult AttemptReadBitmap(this StreamSystem item, string path, out Bitmap bitmap, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            return item.AttemptRead<Bitmap>(path, delegate(Stream stream) {
                return new Bitmap(Bitmap.FromStream(stream));
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