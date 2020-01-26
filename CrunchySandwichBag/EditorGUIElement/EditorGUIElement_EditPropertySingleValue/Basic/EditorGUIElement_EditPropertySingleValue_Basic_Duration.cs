using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    [EditorGUIElementForType(typeof(Duration), true)]
    public class EditorGUIElement_EditPropertySingleValue_Basic_Duration : EditorGUIElement_EditPropertySingleValue_Basic<Duration>
    {
        protected override Duration DrawValueInternal(Rect rect, Duration value)
        {
            Rect view_rect;

            rect.SplitByXRightPercent(0.5f, out rect, out view_rect);

            value = EditorGUI.TextField(rect, value.ToString()).ParseDuration();
            EditorGUI.LabelField(view_rect, value.ToString());

            return value;
        }

        public EditorGUIElement_EditPropertySingleValue_Basic_Duration(EditProperty_Single_Value p) : base(p) { }
    }
}