using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class ScreenExtensions
    {
        static public Vector2 GetSize()
        {
            return new Vector2(Screen.width, Screen.height);
        }

        static public Vector2 GetCenter()
        {
            return GetSize() * 0.5f;
        }

        static public Rect GetRect()
        {
            return new Rect(Vector2.zero, GetSize());
        }
    }
}