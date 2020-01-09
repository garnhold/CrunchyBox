using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    
    static public class SerializedObjectExtensions_TargetType
    {
        static public Type GetTargetType(this SerializedObject item)
        {
            return item.targetObjects.Convert(z => z.GetTypeEX()).GetCommonAncestor();
        }
    }
}