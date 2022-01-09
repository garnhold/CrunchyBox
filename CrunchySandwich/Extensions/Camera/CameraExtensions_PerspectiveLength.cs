using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class CameraExtensions_PerspectiveLength
    {
        static public float GetPerspectiveWorldPerPixel(this Camera item, float distance)
        {
            return (TrigDegree.Sin(item.fieldOfView / 2.0f) * distance * 2.0f) / item.GetPixelHeight();
        }

        static public float ConvertPerspectiveWorldToPixels(this Camera item, float distance, float length)
        {
            return length / item.GetPerspectiveWorldPerPixel(distance);
        }

        static public float ConvertPixelsToPerspectiveWorld(this Camera item, float distance, float length)
        {
            return length * item.GetPerspectiveWorldPerPixel(distance);
        }
    }
}