﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    
    static public class SerializedPropertyExtensions_Array_Elements
    {
        static public IEnumerable<SerializedProperty> GetArrayElements(this SerializedProperty item)
        {
            for (int i = 0; i < item.arraySize; i++)
                yield return item.GetArrayElementAtIndex(i);
        }
    }
}