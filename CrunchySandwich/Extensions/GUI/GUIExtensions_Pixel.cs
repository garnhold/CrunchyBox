using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public partial class GUIExtensions
    {
        static private Texture2D WHITE_PIXEL_TEXTURE;
        static public Texture2D GetWhitePixelTexture()
        {
            if (WHITE_PIXEL_TEXTURE == null)
                WHITE_PIXEL_TEXTURE = Texture2DExtensions.CreateWhite(1, 1);

            return WHITE_PIXEL_TEXTURE;
        }
    }
}