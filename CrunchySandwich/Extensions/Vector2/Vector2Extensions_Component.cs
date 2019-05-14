using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector2Extensions_Component
    {
        static public Vector2 GetComponentMultiply(this Vector2 item, float x, float y)
        {
            return new Vector2(item.x * x, item.y * y);
        }
        static public Vector2 GetComponentMultiply(this Vector2 item, Vector2 other)
        {
            return item.GetComponentMultiply(other.x, other.y);
        }

        static public Vector2 GetComponentDivide(this Vector2 item, float x, float y)
        {
            return new Vector2(item.x / x, item.y / y);
        }
        static public Vector2 GetComponentDivide(this Vector2 item, Vector2 other)
        {
            return item.GetComponentDivide(other.x, other.y);
        }

        static public float GetMaxComponent(this Vector2 item)
        {
            return item.x.Max(item.y);
        }

        static public float GetMinComponent(this Vector2 item)
        {
            return item.x.Min(item.y);
        }
    }
}