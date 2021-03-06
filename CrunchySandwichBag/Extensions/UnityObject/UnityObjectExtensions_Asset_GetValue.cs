﻿using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    
    static public class UnityObjectExtensions_Asset_GetValue
    {
        static public object GetAssetValue(this UnityEngine.Object item, string name)
        {
            return new SerializedObject(item).GetChildValue(name);
        }
        static public T GetAssetValue<T>(this UnityEngine.Object item, string name)
        {
            return new SerializedObject(item).GetChildValue<T>(name);
        }
    }
}