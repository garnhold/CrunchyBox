using System;
using System.IO;
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
    static public class TypeExtensions_EditorGUIElement
    {
        static public Type GetEditorGUIElementTypeForType(this Type item)
        {
            return ForTypes.GetBestTypeForType<EditorGUIElementForTypeAttribute>(item)
                ??
                item.IsTypicalIEnumerable().ConvertBool(typeof(EditorGUIElement_Complex_EditPropertyArray_Generic))
                ??
                typeof(EditorGUIElement_Composite_EditPropertySingleValue_EditTarget_Generic);
        }

        static public EditorGUIElement CreateEditorGUIElement(this Type item, EditProperty property)
        {
            return item.GetEditorGUIElementTypeForType().CreateInstance<EditorGUIElement>(property);
        }
    }
}