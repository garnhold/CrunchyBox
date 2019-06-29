using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public partial class EditorGUIExtensions
    {
        static public void DrawSprite(Rect rect, Sprite sprite)
        {
            if (sprite != null)
            {
                Texture2D texture = sprite.Sideload().GetScaledByFactor(2.0f);

                texture.filterMode = FilterMode.Point;

                GUI.DrawTexture(rect, texture, ScaleMode.ScaleToFit);
            }
        }
    }
}