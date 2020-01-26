using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Texture2DExtensions_Color_Fill
    {
        static public void SetAsSolidColor(this Texture2D item, Color color)
        {
            item.SetPixels(color.Repeat(item.GetNumberPixels()).ToArray());
            item.Apply();
        }

        static public void SetAsClear(this Texture2D item)
        {
            item.SetAsSolidColor(Color.clear);
        }

        static public void SetAsWhite(this Texture2D item)
        {
            item.SetAsSolidColor(Color.white);
        }

        static public void SetAsBlack(this Texture2D item)
        {
            item.SetAsSolidColor(Color.black);
        }
    }
}