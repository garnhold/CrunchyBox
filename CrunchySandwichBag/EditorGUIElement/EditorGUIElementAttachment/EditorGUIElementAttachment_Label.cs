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
    public class EditorGUIElementAttachment_Label : EditorGUIElementAttachment
    {
        private float percent_width;
        private EditorGUIElement_Single_Text label;

        static public readonly float DEFAULT_PERCENT_WIDTH = 0.385f;

        public EditorGUIElementAttachment_Label(string l, float w)
        {
            percent_width = w;

            label = new EditorGUIElement_Single_Text(l, EditorGUIElement_Single.DEFAULT_HEIGHT);
            label.AddAttachment(new EditorGUIElementAttachment_Singular_Margin(0.0f));
            label.AddAttachment(new EditorGUIElementAttachment_Singular_Padding(0.0f));
        }

        public EditorGUIElementAttachment_Label(string l) : this(l, EditorGUIElementAttachment_Label.DEFAULT_PERCENT_WIDTH) { }

        public override Rect LayoutElementInternal(Rect rect, EditorGUILayoutState state)
        {
            Rect label_rect;
            Rect remainder;

            rect.SplitByXLeftOffset(rect.width * percent_width, out label_rect, out remainder);

            label.Layout(label_rect, state);
            return remainder;
        }

        public override void DrawInternal(Rect view)
        {
            label.Draw(view);
        }

        public override float ModifyElementHeight(float height)
        {
            return height.Max(label.GetHeight());
        }
    }
}