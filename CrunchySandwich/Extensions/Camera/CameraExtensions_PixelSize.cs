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
        static public void SetPixelSize(this Camera item, Vector2 size)
        {
            item.aspect = size.x / size.y;
            item.pixelRect = new Rect(item.pixelRect.min, size);
        }
        static public void SetPixelWidth(this Camera item, int width)
        {
            item.SetPixelSize(item.GetPixelSize().GetWithX(width));
        }
        static public void SetPixelHeight(this Camera item, int height)
        {
            item.SetPixelSize(item.GetPixelSize().GetWithY(height));
        }

        static public int GetPixelWidth(this Camera item)
        {
            float width = item.rect.width;

            if (width > 1.0f)
                return (int)(item.pixelWidth * width);

            return item.pixelWidth;
        }

        static public int GetPixelHeight(this Camera item)
        {
            float height = item.rect.height;

            if(height > 1.0f)
                return (int)(item.pixelHeight * height);

            return item.pixelHeight;
        }

        static public Vector2 GetPixelSize(this Camera item)
        {
            return new Vector2(item.GetPixelWidth(), item.GetPixelHeight());
        }
    }
}