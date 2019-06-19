using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwichBag
{
    static public class SerializedPropertyExtensions_SubValue
    {
        static public void SetChildValue(this SerializedProperty item, string name, object value)
        {
            item.FindPropertyRelative(name).SetValue(value);
        }

        static public object GetChildValue(this SerializedProperty item, string name)
        {
            return item.FindPropertyRelative(name).GetValue();
        }
    }
}