using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditorGUIElement_Texture : EditorGUIElement
    {
        private Texture2D texture;

        protected override void DrawElementInternal(Rect view)
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