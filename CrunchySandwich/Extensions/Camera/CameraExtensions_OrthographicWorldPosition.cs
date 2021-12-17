using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class CameraExtensions_OrthographicWorldPosition
    {
        static public float GetOrthographicWorldLeft(this Camera item)
        {
            return item.GetPlanarPosition().x + item.GetOrthographicLeft();
        }
        static public float GetOrthographicWorldRight(this Camera item)
        {
            return item.GetPlanarPosition().x + item.GetOrthographicRight();
        }

        static public float GetOrthographicWorldTop(this Camera item)
        {
            return item.GetPlanarPosition().y + item.GetOrthographicTop();
        }
        static public float GetOrthographicWorldBottom(this Camera item)
        {
            return item.GetPlanarPosition().y + item.GetOrthographicBottom();
        }

        static public Vector2 GetOrthographicWorldLeftTop(this Camera item)
        {
            return new Vector2(item.GetOrthographicWorldLeft(), item.GetOrthographicWorldTop());
        }
        static public Vector2 GetOrthographicWorldLeftBottom(this Camera item)
        {
            return new Vector2(item.GetOrthographicWorldLeft(), item.GetOrthographicWorldBottom());
        }
        static public Vector2 GetOrthographicWorldRightTop(this Camera item)
        {
            return new Vector2(item.GetOrthographicWorldRight(), item.GetOrthographicWorldTop());
        }
        static public Vector2 GetOrthographicWorldRightBottom(this Camera item)
        {
            return new Vector2(item.GetOrthographicWorldRight(), item.GetOrthographicWorldBottom());
        }
    }
}