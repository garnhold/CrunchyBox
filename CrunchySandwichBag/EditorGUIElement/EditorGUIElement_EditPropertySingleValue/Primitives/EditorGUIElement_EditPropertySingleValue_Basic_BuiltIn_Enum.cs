using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;
    
    [EditorGUIElementForType(typeof(Enum), true)]
    public class EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn_Enum : EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn<Enum>
    {
        private bool is_flags;

        protected override float DoPlanInternal()
        {
            return LINE_HEIGHT;
        }

        protected override Enum DrawBuiltInInternal(Rect rect, GUIContent label, Enum value)
        {
            if (is_flags)
                return (Enum)EditorGUI.EnumFlagsField(rect, label, value);

            return (Enum)EditorGUI.EnumPopup(rect, label, value);
        }

        public EditorGUIElement_EditPropertySingleValue_Basic_BuiltIn_Enum(EditProperty_Single_Value p) : base(p)
        {
            is_flags = p.HasCustomAttributeOfType<FlagsAttribute>(true);
        }
    }
}