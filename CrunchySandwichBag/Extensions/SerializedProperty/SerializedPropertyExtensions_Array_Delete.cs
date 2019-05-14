using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwichBag
{
    static public class SerializedPropertyExtensions_Array_Delete
    {
        static public void DeleteSerializedPropertyElement(this SerializedProperty item, SerializedProperty element)
        {
            item.DeleteArrayElementAtIndex(item.FindIndexOfArrayElement(element));
        }
    }
}