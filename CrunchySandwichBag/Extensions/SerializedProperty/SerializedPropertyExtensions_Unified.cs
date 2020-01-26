using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    
    static public class SerializedPropertyExtensions_Unified
    {
        static public bool IsUnified(this SerializedProperty item)
        {
            try
            {
                if (item.hasMultipleDifferentValues == false)
                    return true;
            }
            catch (Exception)
            {
            }

            return false;
        }
    }
}