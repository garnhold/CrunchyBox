using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    
    static public class SerializedPropertyExtensions_Compare
    {
        static public bool AreSerializedPropertysEqual(this SerializedProperty item, SerializedProperty other)
        {
            if(item.GetPropertyPathEX() == other.GetPropertyPathEX())
                return true;

            return false;
        }

        static public bool IsValid(this SerializedProperty item)
        {
            if (item != null)
            {
                if (item.serializedObject.FindProperty(item.propertyPath) != null)
                    return true;
            }

            return false;
        }
    }
}