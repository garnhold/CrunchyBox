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
    public class EditorGUIElement_Single_Texture : EditorGUIElement_Single
    {
        private Texture2D texture;

        protected override bool DrawSingleInternal(Rect rect)
        {
            if (texture != null)
                EditorGUI.DrawTextureTransparent(rect, texture);

            return true;
        }

        public EditorGUIElement_Single_Texture(Texture2D t, float h) : base(h)
        {
            texture = t;
        }
    }
}