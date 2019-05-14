using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwichBag
{
    static public class SerializedPropertyExtensions_Array_Insert
    {
        static public void InsertAndNullArrayElementAtIndex(this SerializedProperty item, int index)
        {
            item.InsertArrayElementAtIndex(index);
            item.GetArrayElementAtIndex(index).ClearValue();
        }

        static public void InsertArrayElementAbove(this SerializedProperty item, SerializedProperty element)
        {
            item.InsertAndNullArrayElementAtIndex(item.FindIndexOfArrayElement(element) + 1);
        }

        static public void InsertArrayElementBelow(this SerializedProperty item, SerializedProperty element)
        {
            item.InsertAndNullArrayElementAtIndex(item.FindIndexOfArrayElement(element));
        }
    }
}