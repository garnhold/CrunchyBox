using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    [AttributeUsage(AttributeTargets.Class)]
    public class EditorGUIElementForTypeAttribute : ForTypeAttribute
    {
        public EditorGUIElementForTypeAttribute(Type t, bool c) : base(t, c) { }
        public EditorGUIElementForTypeAttribute(Type t) : this(t, false) { }
    }
}