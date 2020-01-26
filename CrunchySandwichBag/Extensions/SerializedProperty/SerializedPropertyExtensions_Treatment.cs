using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    
    static public class SerializedPropertyExtensions_Treatment
    {
        static public bool IsTypicalArray(this SerializedProperty item)
        {
            if (item.isArray)
            {
                if (item.propertyType != SerializedPropertyType.String)
                    return true;
            }

            return false;
        }

        static public bool IsGenericObject(this SerializedProperty item)
        {
            if (item.isArray == false)
            {
                if (item.propertyType == SerializedPropertyType.Generic)
                    return true;
            }

            return false;
        }
    }
}