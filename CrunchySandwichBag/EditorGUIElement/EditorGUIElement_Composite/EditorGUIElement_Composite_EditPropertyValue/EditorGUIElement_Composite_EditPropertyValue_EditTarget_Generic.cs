using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditorGUIElement_Composite_EditPropertyValue_EditTarget_Generic : EditorGUIElement_Composite_EditPropertyValue_EditTarget
    {
        protected override EditorGUIElement CreateElementEditTarget(EditTarget target)
        {
 	        return new EditorGUIElement_Complex_EditTarget(target);
        }

        public EditorGUIElement_Composite_EditPropertyValue_EditTarget_Generic(EditProperty_Value p) : base(p) { }
    }
}