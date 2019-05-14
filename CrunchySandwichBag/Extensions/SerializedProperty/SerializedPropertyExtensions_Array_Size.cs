using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwichBag
{
    static public class SerializedPropertyExtensions_Array_Size
    {
        static public void SetArraySize(this SerializedProperty item, int size)
        {
            if (size < 0)
                size = 0;

            while (item.arraySize < size)
                item.PushArrayElement();

            while (item.arraySize > size)
                item.PopArrayElement();
        }

        static public int GetArraySize(this SerializedProperty item)
        {
            return item.arraySize;
        }
    }
}