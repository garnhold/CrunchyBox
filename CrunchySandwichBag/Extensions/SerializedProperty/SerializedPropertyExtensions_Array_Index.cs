using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwichBag
{
    static public class SerializedPropertyExtensions_Array_Index
    {
        static public int GetArrayFinalIndex(this SerializedProperty item)
        {
            return item.arraySize - 1;
        }

        static public bool IsArrayIndexValid(this SerializedProperty item, int index)
        {
            if (item.IsTypicalArray())
            {
                if (index >= 0 && index < item.arraySize)
                    return true;
            }

            return false;
        }
    }
}