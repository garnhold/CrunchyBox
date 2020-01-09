using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class RenderTextureExtensions_Texture2D
    {
        static public Texture2D CreateTexture2D(this RenderTexture item)
        {
            Texture2D texture = new Texture2D(item.width, item.height);

            item.Use(delegate() {
                texture.ReadPixels(texture.GetRect(), 0, 0);
            });

            texture.Apply();
            return texture;
        }
    }
}