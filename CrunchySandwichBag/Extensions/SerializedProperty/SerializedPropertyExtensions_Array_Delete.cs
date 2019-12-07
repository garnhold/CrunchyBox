using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    
    static public class SerializedPropertyExtensions_Array_Delete
    {
        static public void DeleteSerializedPropertyElement(this SerializedProperty item, SerializedProperty element)
        {
            item.DeleteArrayElementAtIndex(item.FindIndexOfArrayElement(element));
        }
    }
}