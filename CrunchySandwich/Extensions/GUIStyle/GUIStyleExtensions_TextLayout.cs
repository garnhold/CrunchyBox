using System;

using CrunchyDough;
using UnityEngine;

namespace CrunchySandwich
{
    static public class GUIStyleExtensions_TextLayout
    {
        static public float GetTextLayoutWidth(this GUIStyle item, string text)
        {
            return item.font.GetTextLayoutWidth(text, item.fontSize);
        }

        static public string LayoutText(this GUIStyle item, string text, float max_width)
        {
            return item.font.LayoutText(text, max_width, item.fontSize);
        }
    }
}