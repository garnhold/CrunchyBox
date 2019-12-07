using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Salt;
    using Noodle;
    using Bun;
    using Sandwich;
    
    [AttributeUsage(AttributeTargets.Class)]
    public class EditorGUIElementForTypeAttribute : ForTypeAttribute
    {
        public EditorGUIElementForTypeAttribute(Type t, bool c) : base(t, c) { }
        public EditorGUIElementForTypeAttribute(Type t) : this(t, false) { }
    }
}