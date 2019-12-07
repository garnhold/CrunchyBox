using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sandwich;
    
    public class EditorGUIElementAttachment_Singular_Padding_Indent : EditorGUIElementAttachment_Singular_Padding
    {
        static public readonly float DEFAULT_INDENT = 18.0f;

        public EditorGUIElementAttachment_Singular_Padding_Indent(float i) : base(i, 0.0f, 0.0f, 0.0f) { }
        public EditorGUIElementAttachment_Singular_Padding_Indent() : this(DEFAULT_INDENT) { }
    }
}