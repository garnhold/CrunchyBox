using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
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