using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class TextMeshExtensions_TextLayout
    {
        static public string LayoutText(this TextMesh item, string text, float max_width)
        {
            float width_scale = item.characterSize * item.GetPlanarScale().x;

            return item.font.LayoutText(text, max_width / width_scale);
        }

        static public void SetText(this TextMesh item, string text)
        {
            item.text = text;
        }
        static public void SetText(this TextMesh item, string text, float max_width)
        {
            item.SetText(item.LayoutText(text, max_width));
        }
    }
}