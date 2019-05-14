using System;
using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class ColorExtensions_Vectors
    {
        static public Vector2 GetVector2(this Color item)
        {
            return new Vector2(item.r - 0.5f, item.g - 0.5f);
        }

        static public Vector3 GetVector3(this Color item)
        {
            return new Vector3(item.r - 0.5f, item.g - 0.5f, item.b - 0.5f);
        }
    }
}