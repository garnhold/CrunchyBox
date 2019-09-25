using System;

using CrunchyDough;
using UnityEngine;

namespace CrunchySandwich
{
    static public class GUISkinExtensions_TextLayout
    {
        static public float GetDefaultTextLayoutWidth(this GUISkin item, string text)
        {
            return item.font.GetTextLayoutWidth(text);
        }
        static public float GetTextLayoutWidth(this GUISkin item, GUIStyle style, string text)
        {
            if (style.font != null)
                return style.font.GetTextLayoutWidth(text);

            return item.GetDefaultTextLayoutWidth(text);
        }        

        static public string LayoutDefaultText(this GUISkin item, string text, float max_width)
        {
            return item.font.LayoutText(text, max_width);
        }
        static public string LayoutText(this GUISkin item, GUIStyle style, string text, float max_width)
        {
            float effective_width = max_width - style.padding.horizontal;

            if (style.font != null)
                return style.font.LayoutText(text, effective_width);

            return item.LayoutDefaultText(text, effective_width);
        }
        
    }
}