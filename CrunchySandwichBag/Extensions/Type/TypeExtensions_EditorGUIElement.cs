using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Salt;
    using Noodle;
    using Bun;
    using Sandwich;
    
    static public class TypeExtensions_EditorGUIElement
    {
        static public EditorGUIElement CreateExplicitEditorGUIElementForType(this Type item, EditProperty property)
        {
            Type element_type = ForTypes.GetBestTypeForType<EditorGUIElementForTypeAttribute>(item);

            if (element_type != null)
            {
                return element_type.CreateBestInstance<EditorGUIElement>(property, item) ??
                    element_type.CreateBestInstance<EditorGUIElement>(property);
            }

            return null;
        }

        static public EditorGUIElement CreateBestEditorGUIElementForType(this Type item, EditProperty property)
        {
            EditorGUIElement element;

            element = item.CreateExplicitEditorGUIElementForType(property);
            if (element != null)
                return element;

            if(item.IsTypicalIEnumerable())
                return new EditorGUIElement_Complex_EditPropertyArray_Generic((EditProperty_Array)property);

            return new EditorGUIElement_Composite_EditPropertySingleValue_Generic((EditProperty_Single_Value)property);
        }
    }
}