using System;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
{
    static public class GUIContentExtensions_Layout
    {
        static public float GetLabelLayoutWidth(this GUIContent item)
        {
            return GUI.skin.GetLabelTextLayoutWidth(item.text) + item.image.IfNotNull(i => i.width);
        }
    }
}