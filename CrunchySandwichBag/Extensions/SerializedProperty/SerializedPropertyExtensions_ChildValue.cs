using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
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
        static public object GetChildValue(this SerializedProperty item, string name, Type type)
        {
            return item.FindPropertyRelative(name).GetValue(type);
        }
        static public T GetChildValue<T>(this SerializedProperty item, string name)
        {
            return item.GetChildValue(name).ConvertEX<T>();
        }
    }
}