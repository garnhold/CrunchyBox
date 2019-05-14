﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwichBag
{
    static public class SerializedPropertyExtensions_Array_Search
    {
        static public int FindIndexOfArrayElement(this SerializedProperty item, SerializedProperty element)
        {
            return item.GetArrayElements().FindIndexOf(e => e.AreSerializedPropertysEqual(element));
        }
    }
}