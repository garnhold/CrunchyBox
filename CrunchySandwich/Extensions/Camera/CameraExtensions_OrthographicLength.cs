using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class CameraExtensions_OrthographicLenth
    {
        static public float ConvertOrthographicWorldToPixels(this Camera item, float length)
        {
            return length * (item.GetPixelWidth() / item.GetOrthographicWidth());
        }

        static public float ConvertPixelsToOrthographicWorld(this Camera item, float length)
        {
            return length * (item.GetOrthographicWidth() / item.GetPixelWidth());
        }
    }
}