using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
{
    static public partial class GUIExtensions
    {
        static public void DrawRect(Rect rect)
        {
            GUI.DrawTexture(
                rect,
                GetWhitePixelTexture()
            );
        }
    }
}