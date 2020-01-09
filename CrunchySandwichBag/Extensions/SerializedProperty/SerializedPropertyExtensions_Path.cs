using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    
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