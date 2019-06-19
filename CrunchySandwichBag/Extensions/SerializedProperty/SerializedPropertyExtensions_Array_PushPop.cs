using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwichBag
{
    static public class SerializedPropertyExtensions_Array_PushPop
    {
        static public SerializedProperty PushArrayElement(this SerializedProperty item)
        {
            return item.InsertAndNullArrayElementAtIndex(item.GetArrayFinalIndex() + 1);
        }

        static public void PopArrayElement(this SerializedProperty item)
        {
            item.DeleteArrayElementAtIndex(item.GetArrayFinalIndex());
        }
    }
}