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
    
    public abstract class EditorGUIElement_Complex_EditPropertySingleValue<T> : EditorGUIElement_Complex<T>
    {
        private EditProperty_Single_Value property;

        public EditorGUIElement_Complex_EditPropertySingleValue(EditProperty_Single_Value p)
        {
            property = p;
        }

        public EditProperty_Single_Value GetProperty()
        {
            return property;
        }
    }
}