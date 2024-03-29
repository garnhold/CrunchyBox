﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class CameraExtensions_OrthographicLength
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