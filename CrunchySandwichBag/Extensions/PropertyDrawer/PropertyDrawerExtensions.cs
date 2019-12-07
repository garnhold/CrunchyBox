using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    
    static public class PropertyDrawerExtensions
    {
        static public EditorGUIElement CreateEditorGUIElement(this PropertyDrawer item, SerializedProperty property)
        {
            PropertyDrawerEX property_drawer_ex;

            if (item.Convert<PropertyDrawerEX>(out property_drawer_ex))
                return property_drawer_ex.CreateEditorGUIElement(property);

            return new EditorGUIElement_SerializedProperty_PropertyDrawer(property, item);
        }
    }
}