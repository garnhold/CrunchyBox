using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    static public class EditorGUIElementExtensions_Label_Index
    {
        static public T LabelWithIndex<T>(this T item, EditProperty_Array a, int i, Process p) where T : EditorGUIElement
        {
            item.AddAttachment(new EditorGUIElementAttachment_Singular_Label_Index(a, i, p));

            return item;
        }
    }
}