using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwichBag
{
    static public class SerializedObjectExtensions_ChildValue
    {
        static public void SetChildValue(this SerializedObject item, string name, object value)
        {
            item.FindProperty(name).SetValue(value);
        }

        static public object GetChildValue(this SerializedObject item, string name)
        {
            return item.FindProperty(name).GetValue();
        }
    }
}