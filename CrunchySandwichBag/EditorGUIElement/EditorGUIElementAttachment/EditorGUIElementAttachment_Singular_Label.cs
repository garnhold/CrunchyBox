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
    
    public abstract class EditorGUIElementAttachment_Singular_Label : EditorGUIElementAttachment_Singular
    {
        public abstract float GetLabelWidth();

        public EditorGUIElementAttachment_Singular_Label() : base("Label") { }
    }
}