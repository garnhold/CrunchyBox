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
    public class EditorGUIElement_Composite_EditPropertySingleValue_EditTarget_Generic : EditorGUIElement_Composite_EditPropertySingleValue
    {
        protected override EditorGUIElement CreateElement()
        {
 	        return new EditorGUIElement_Complex_EditTarget(GetProperty().GetContents());
        }

        public EditorGUIElement_Composite_EditPropertySingleValue_EditTarget_Generic(EditProperty_Single_Value p) : base(p) { }
    }
}