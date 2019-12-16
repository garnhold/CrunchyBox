using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Bun;
    using Sandwich;
    
    public class EditorGUIElement_Composite_EditPropertySingleValue_Generic : EditorGUIElement_Composite_EditPropertySingleValue
    {
        protected override EditorGUIElement CreateElement()
        {
 	        return new EditorGUIElement_Complex_EditTarget(GetProperty().GetContents());
        }

        public EditorGUIElement_Composite_EditPropertySingleValue_Generic(EditProperty_Single_Value p) : base(p) { }
    }
}