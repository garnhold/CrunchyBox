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
    public abstract class EditorGUIElementAttachment_Singular_GUIContentLabel : EditorGUIElementAttachment_Singular
    {
        private GUIContent label;

        public EditorGUIElementAttachment_Singular_GUIContentLabel(GUIContent l) : base("Label")
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
    }
}