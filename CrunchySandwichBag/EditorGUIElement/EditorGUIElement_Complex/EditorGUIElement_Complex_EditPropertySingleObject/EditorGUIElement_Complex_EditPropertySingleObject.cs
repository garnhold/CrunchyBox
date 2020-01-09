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
    
    public abstract class EditorGUIElement_Complex_EditPropertySingleObject<T> : EditorGUIElement_Complex<T>
    {
        private EditProperty_Single_Object property;

        public EditorGUIElement_Complex_EditPropertySingleObject(EditProperty_Single_Object p)
        {
            property = p;
        }

        public EditProperty_Single_Object GetEditPropertyObject()
        {
            return property;
        }
    }
}