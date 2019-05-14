using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwichBag
{
    static public class SerializedPropertyExtensions_Path
    {
        static public string GetPropertyPathEX(this SerializedProperty item)
        {
            if (item != null)
                return item.propertyPath;

            return "";
        }
    }
}