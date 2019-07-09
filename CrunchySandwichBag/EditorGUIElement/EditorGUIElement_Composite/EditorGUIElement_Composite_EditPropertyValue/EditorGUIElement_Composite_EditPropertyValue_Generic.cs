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
    public class EditorGUIElement_Composite_EditPropertyValue_Generic : EditorGUIElement_Composite_EditPropertyValue
    {
        static private EditorGUIElement CreateElement(EditProperty_Value property)
        {
            EditTarget value;
            EditorGUIElement_Container_Auto container = new EditorGUIElement_Container_Auto_Simple_VerticalStrip();

            if (property.TryGetContents(out value))
                container.AddChild(new EditorGUIElement_Complex_EditTarget(value));
            else
                container.AddChild(new EditorGUIElement_Single_UnhandledEditProperty(property));

            return container;
        }

        public EditorGUIElement_Composite_EditPropertyValue_Generic(EditProperty_Value p) : base(CreateElement(p), p)
        {
        }
    }
}