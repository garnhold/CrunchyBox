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
    public class EditorGUIElementAttachment_ScrollBox : EditorGUIElementAttachment
    {
        private Rect box_rect;
        private Rect contents_rect;

        public override void PreLayoutInternal(Rect rect, float label_width)
        {
            base.PreLayoutInternal(rect, label_width);
        }
    }
}