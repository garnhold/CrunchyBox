using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Sauce;
    
    public class Surface_Texture2D : Surface<Color>
    {
        private Texture2D texture;

        public Surface_Texture2D(Texture2D t)
        {
            texture = t;
        }

        public void MixPigmentAt(int x, int y, Color pigment, float coverage, Mixer<Color> pigment_mixer)
        {
            if (texture.IsIndexValid(x, y))
                texture.SetPixel(x, y, pigment_mixer.Mix(pigment, texture.GetPixel(x, y), coverage));
        }

        public void SetPigmentAt(int x, int y, Color pigment)
        {
            if (texture.IsIndexValid(x, y))
                texture.SetPixel(x, y, pigment);
        }

        public Color GetPigmentAt(int x, int y)
        {
            if (texture.IsIndexValid(x, y))
                return texture.GetPixel(x, y);

            return Color.clear;
        }

        public int GetWidth()
        {
            return texture.width;
        }

        public int GetHeight()
        {
            return texture.height;
        }

        public IEnumerable<VectorI2> GetSurfacePoints()
        {
            for (int y = 0; y < texture.height; y++)
            {
                for (int x = 0; x < texture.width; x++)
                    yield return new VectorI2(x, y);
            }
        }
    }
}