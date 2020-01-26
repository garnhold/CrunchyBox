using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;    
    static public class SerializedPropertyExtensions_SubValue
    {
        static public void SetChildValue(this SerializedProperty item, string name, object value)
        {
            item.ForceProperty(name).SetValue(value);
        }

        static public object GetChildValue(this SerializedProperty item, string name)
        {
            return item.ForceProperty(name).GetValue();
        }
        static public object GetChildValue(this SerializedProperty item, string name, Type type)
        {
            return item.ForceProperty(name).GetValue(type);
        }
        static public T GetChildValue<T>(this SerializedProperty item, string name)
        {
            return item.GetChildValue(name, typeof(T)).Convert<T>();
        }
    }
}