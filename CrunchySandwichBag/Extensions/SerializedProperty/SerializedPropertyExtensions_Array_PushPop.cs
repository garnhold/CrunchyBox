using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    
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