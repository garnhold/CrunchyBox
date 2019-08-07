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
    public abstract class EditorGUIElementAttachment_Singular_Label_GUIContent : EditorGUIElementAttachment_Singular_Label
    {
        private GUIContent label;

        public EditorGUIElementAttachment_Singular_Label_GUIContent(GUIContent l)
        {
            label = l;
        }

        public bool HasLabel()
        {
            if (label != GUIContent.none)
                return true;

            return false;
        }

        public GUIContent GetLabel()
        {
            return label;
        }

        public override float GetLabelWidth()
        {
            return label.GetLabelLayoutWidth();
        }
    }
}