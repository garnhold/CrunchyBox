using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class CameraExtensions_OrthographicSize
    {
        static public void SetOrthographicExtents(this Camera item, Vector2 extents)
        {
            item.aspect = extents.x / extents.y;
            item.orthographicSize = extents.y;
        }
        static public void SetOrthographicHalfHeight(this Camera item, float height)
        {
            item.SetOrthographicExtents(item.GetOrthographicExtents().GetWithY(height));
        }
        static public void SetOrthographicHalfWidth(this Camera item, float width)
        {
            item.SetOrthographicExtents(item.GetOrthographicExtents().GetWithX(width));
        }

        static public void SetOrthographicSize(this Camera item, Vector2 size)
        {
            item.SetOrthographicExtents(size * 0.5f);
        }
        static public void SetOrthographicWidth(this Camera item, float width)
        {
            item.SetOrthographicHalfWidth(width * 0.5f);
        }
        static public void SetOrthographicHeight(this Camera item, float height)
        {
            item.SetOrthographicHalfHeight(height * 0.5f);
        }

        static public float GetOrthographicHalfHeight(this Camera item)
        {
            return item.orthographicSize;
        }
        static public float GetOrthographicHalfWidth(this Camera item)
        {
            return item.GetOrthographicHalfHeight() * item.aspect;
        }
        static public Vector2 GetOrthographicExtents(this Camera item)
        {
            return new Vector2(item.GetOrthographicHalfWidth(), item.GetOrthographicHalfHeight());
        }

        static public float GetOrthographicHeight(this Camera item)
        {
            return item.GetOrthographicHalfHeight() * 2.0f;
        }
        static public float GetOrthographicWidth(this Camera item)
        {
            return item.GetOrthographicHalfWidth() * 2.0f;
        }
        static public Vector2 GetOrthographicSize(this Camera item)
        {
            return new Vector2(item.GetOrthographicWidth(), item.GetOrthographicHeight());
        }
    }
}