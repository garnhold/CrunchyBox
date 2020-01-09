using System;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class GUIContentExtensions_Layout
    {
        static public float GetLabelLayoutWidth(this GUIContent item)
        {
            return GUI.skin.GetTextLayoutWidth(GUI.skin.label, item.text) + item.image.IfNotNull(i => i.width);
        }
    }
}