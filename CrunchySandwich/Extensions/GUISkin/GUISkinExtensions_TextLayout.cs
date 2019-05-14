using System;

using CrunchyDough;
using UnityEngine;

namespace CrunchySandwich
{
    static public class GUISkinExtensions_TextLayout
    {
        static public float GetDefaultTextLayoutWidth(this GUISkin item, string text)
        {
            return item.font.GetTextLayoutWidth(text, item.font.fontSize);
        }
    }
}