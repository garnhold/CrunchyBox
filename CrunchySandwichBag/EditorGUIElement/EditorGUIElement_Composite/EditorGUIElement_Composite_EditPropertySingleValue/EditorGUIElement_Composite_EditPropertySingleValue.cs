using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;    using Sandwich;
    
    public abstract class EditorGUIElement_Composite_EditPropertySingleValue : EditorGUIElement_Composite
    {
        private EditProperty_Single_Value property;

        public EditorGUIElement_Composite_EditPropertySingleValue(EditProperty_Single_Value p)
        {
            property = p;
        }

        public EditProperty_Single_Value GetProperty()
        {
            return property;
        }
    }
}