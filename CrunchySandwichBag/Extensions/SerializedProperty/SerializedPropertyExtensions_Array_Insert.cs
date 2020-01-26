using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    
    static public class SerializedPropertyExtensions_Array_Insert
    {
        static public SerializedProperty InsertAndNullArrayElementAtIndex(this SerializedProperty item, int index)
        {
            item.InsertArrayElementAtIndex(index);

            return item.GetArrayElementAtIndex(index).Chain(e => e.ClearValue());
        }

        static public SerializedProperty InsertArrayElementAbove(this SerializedProperty item, SerializedProperty element)
        {
            return item.InsertAndNullArrayElementAtIndex(item.FindIndexOfArrayElement(element) + 1);
        }

        static public SerializedProperty InsertArrayElementBelow(this SerializedProperty item, SerializedProperty element)
        {
            return item.InsertAndNullArrayElementAtIndex(item.FindIndexOfArrayElement(element));
        }
    }
}