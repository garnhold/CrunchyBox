using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class Texture2DExtensions
    {
        static public Texture2D Create(int width, int height, TextureFormat format, bool mipmaps)
        {
            return new Texture2D(width, height, format, mipmaps);
        }

        static public Texture2D Create(int width, int height)
        {
            return new Texture2D(width, height);
        }

        static public Texture2D Create(int width, int height, Operation<Color, int, int> operation)
        {
            return new IList2DTransform<Color>(width, height, operation)
                .CreateTexture2D();
        }

        static public Texture2D Create(int width, int height, Color[] colors)
        {
            Texture2D texture = Create(width, height);

            texture.SetPixels(colors);
            texture.Apply();
            return texture;
        }

        static public Texture2D Create(byte[] data)
        {
            Texture2D texture = new Texture2D(1, 1);

            texture.LoadImage(data);
            texture.Apply();
            return texture;
        }

        static public Texture2D Create(string filename)
        {
            return Create(File.ReadAllBytes(filename));
        }

        static public Texture2D CreateSolidColor(int width, int height, Color color)
        {
            return Create(width, height).Chain(z => z.SetAsSolidColor(color));
        }

        static public Texture2D CreateClear(int width, int height)
        {
            return Create(width, height).Chain(z => z.SetAsClear());
        }

        static public Texture2D CreateWhite(int width, int height)
        {
            return Create(width, height).Chain(z => z.SetAsWhite());
        }

        static public Texture2D CreateBlack(int width, int height)
        {
            return Create(width, height).Chain(z => z.SetAsBlack());
        }
    }
}