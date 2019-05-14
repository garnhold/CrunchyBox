using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwichBag
{
    static public class SerializedObjectExtensions_TargetType
    {
        static public Type GetTargetType(this SerializedObject item)
        {
            return item.targetObjects.Convert(z => z.GetTypeEX()).GetCommonAncestor();
        }
    }
}