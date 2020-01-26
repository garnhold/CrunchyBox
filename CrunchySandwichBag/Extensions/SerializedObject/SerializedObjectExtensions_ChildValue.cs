using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;    
    static public class SerializedObjectExtensions_ChildValue
    {
        static public void SetChildValue(this SerializedObject item, string name, object value)
        {
            item.ForceProperty(name).SetValue(value);
        }

        static public object GetChildValue(this SerializedObject item, string name)
        {
            return item.ForceProperty(name).GetValue();
        }
        static public object GetChildValue(this SerializedObject item, string name, Type type)
        {
            return item.ForceProperty(name).GetValue(type);
        }
        static public T GetChildValue<T>(this SerializedObject item, string name)
        {
            return item.GetChildValue(name, typeof(T)).Convert<T>();
        }
    }
}