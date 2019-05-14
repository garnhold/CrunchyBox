using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySauce;

namespace CrunchySystem
{
    public class Surface_Bitmap : Surface<Color>
    {
        private Bitmap bitmap;

        public Surface_Bitmap(Bitmap b)
        {
            bitmap = b;
        }

        public void MixPigmentAt(int x, int y, Color pigment, float coverage, Mixer<Color> pigment_mixer)
        {
            if (bitmap.IsIndexValid(x, y))
                bitmap.SetPixel(x, y, pigment_mixer.Mix(pigment, bitmap.GetPixel(x, y), coverage));
        }

        public void SetPigmentAt(int x, int y, Color pigment)
        {
            if (bitmap.IsIndexValid(x, y))
                bitmap.SetPixel(x, y, pigment);
        }

        public Color GetPigmentAt(int x, int y)
        {
            if (bitmap.IsIndexValid(x, y))
                return bitmap.GetPixel(x, y);

            return Color.Transparent;
        }

        public int GetWidth()
        {
            return bitmap.Width;
        }

        public int GetHeight()
        {
            return bitmap.Height;
        }

        public IEnumerable<SurfacePoint> GetSurfacePoints()
        {
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                    yield return new SurfacePoint(x, y);
            }
        }
    }
}