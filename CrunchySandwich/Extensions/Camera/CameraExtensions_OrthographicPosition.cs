using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class CameraExtensions_OrthographicPosition
    {
        static public float GetOrthographicLeft(this Camera item)
        {
            return -item.GetOrthographicHalfWidth();
        }
        static public float GetOrthographicRight(this Camera item)
        {
            return item.GetOrthographicHalfWidth();
        }

        static public float GetOrthographicTop(this Camera item)
        {
            return item.GetOrthographicHalfHeight();
        }
        static public float GetOrthographicBottom(this Camera item)
        {
            return -item.GetOrthographicHalfHeight();
        }

        static public Vector2 GetOrthographicLeftTop(this Camera item)
        {
            return new Vector2(item.GetOrthographicLeft(), item.GetOrthographicTop());
        }
        static public Vector2 GetOrthographicLeftBottom(this Camera item)
        {
            return new Vector2(item.GetOrthographicLeft(), item.GetOrthographicBottom());
        }
        static public Vector2 GetOrthographicRightTop(this Camera item)
        {
            return new Vector2(item.GetOrthographicRight(), item.GetOrthographicTop());
        }
        static public Vector2 GetOrthographicRightBottom(this Camera item)
        {
            return new Vector2(item.GetOrthographicRight(), item.GetOrthographicBottom());
        }

        static public Rect GetOrthographicRect(this Camera item)
        {
            return RectExtensions.CreateMinMaxRect(
                item.GetOrthographicLeftBottom(),
                item.GetOrthographicRightTop()
            );
        }
    }
}