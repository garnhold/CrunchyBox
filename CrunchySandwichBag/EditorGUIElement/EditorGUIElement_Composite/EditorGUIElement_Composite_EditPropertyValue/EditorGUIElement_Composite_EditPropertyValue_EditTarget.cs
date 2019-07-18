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
    public abstract class EditorGUIElement_Composite_EditPropertyValue_EditTarget : EditorGUIElement_Composite_EditPropertyValue
    {
        protected abstract EditorGUIElement CreateElementEditTarget(EditTarget target);

        protected override EditorGUIElement CreateElement()
        {
            EditTarget value;

            if (GetProperty().TryGetContents(out value))
                return CreateElementEditTarget(value);

            return new EditorGUIElement_UnhandledEditProperty(GetProperty());
        }

        public EditorGUIElement_Composite_EditPropertyValue_EditTarget(EditProperty_Value p) : base(p) { }
    }
}