using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class CameraExtensions_PixelSize
    {
        static public void SetPixelSizeCentered(this Camera item, Vector2 size)
        {
            item.pixelRect = RectExtensions.CreateCenterRect(ScreenExtensions.GetCenter(), size);
        }

        static public int GetPixelWidth(this Camera item)
        {
            if (item.HasRenderTexture())
                return item.targetTexture.width;

            return item.pixelWidth;
        }

        static public int GetPixelHeight(this Camera item)
        {
            if (item.HasRenderTexture())
                return item.targetTexture.height;

            return item.pixelHeight;
        }

        static public Vector2 GetPixelSize(this Camera item)
        {
            return new Vector2(item.GetPixelWidth(), item.GetPixelHeight());
        }
    }
}