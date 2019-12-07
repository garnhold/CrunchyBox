using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    
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