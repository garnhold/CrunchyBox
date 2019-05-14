using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwichBag
{
    static public class SerializedPropertyExtensions_Array_Elements
    {
        static public IEnumerable<SerializedProperty> GetArrayElements(this SerializedProperty item)
        {
            for (int i = 0; i < item.arraySize; i++)
                yield return item.GetArrayElementAtIndex(i);
        }
    }
}