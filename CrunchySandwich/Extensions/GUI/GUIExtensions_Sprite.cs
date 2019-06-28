using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
{
    static public partial class GUIExtensions
    {
        static public void DrawSprite(Rect rect, Sprite sprite, FilterMode filter_mode)
        {
            if (sprite != null)
            {
                Texture2D texture = sprite.Sideload();
                FilterMode old_filter_mode = texture.filterMode;

                texture.filterMode = filter_mode;
                    GUI.DrawTexture(rect, texture, ScaleMode.ScaleToFit);
                texture.filterMode = old_filter_mode;
            }
        }
    }
}