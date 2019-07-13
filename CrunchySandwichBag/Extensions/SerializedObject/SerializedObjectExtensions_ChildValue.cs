﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
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
        static public object GetChildValue(this SerializedObject item, string name, Type type)
        {
            return item.FindProperty(name).GetValue(type);
        }
        static public T GetChildValue<T>(this SerializedObject item, string name)
        {
            return item.GetChildValue(name).ConvertEX<T>();
        }
    }
}