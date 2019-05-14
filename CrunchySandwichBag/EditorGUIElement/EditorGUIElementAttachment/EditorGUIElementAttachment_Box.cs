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
    public class EditorGUIElementAttachment_Box : EditorGUIElementAttachment
    {
        private Color color;
        private Rect box_rect;

        public EditorGUIElementAttachment_Box(Color c)
        {
            color = c;
        }

        public EditorGUIElementAttachment_Box() : this(Color.gray) { }

        public override Rect LayoutElementInternal(Rect rect, float label_width)
        {
            box_rect = rect;

            return rect;
        }

        public override void PreDrawInternal()
        {
            EditorGUI.DrawRect(box_rect, color);
        }
    }
}