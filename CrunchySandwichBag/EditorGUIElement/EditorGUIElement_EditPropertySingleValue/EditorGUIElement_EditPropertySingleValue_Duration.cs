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
    [EditorGUIElementForType(typeof(Duration), true)]
    public class EditorGUIElement_EditPropertySingleValue_Duration : EditorGUIElement_EditPropertySingleValue<Duration>
    {
        protected override Duration DrawValueInternal(Rect rect, Duration value)
        {
            Rect view_rect;

            rect.SplitByXRightPercent(0.5f, out rect, out view_rect);

            value = EditorGUI.TextField(rect, value.ToString()).ParseDuration();
            EditorGUI.LabelField(view_rect, value.ToString());

            return value;
        }

        public EditorGUIElement_EditPropertySingleValue_Duration(EditProperty_Single_Value p) : base(p) { }
    }
}