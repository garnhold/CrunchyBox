using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    public class EditorGUIElement_Texture : EditorGUIElement
    {
        private Texture2D texture;

        protected override void DrawElementInternal(int draw_id, Rect view)
        {
            if (texture != null)
                EditorGUI.DrawTextureTransparent(GetElementRect(), texture);
        }

        public EditorGUIElement_Texture(Texture2D t)
        {
            texture = t;
        }
    }
}