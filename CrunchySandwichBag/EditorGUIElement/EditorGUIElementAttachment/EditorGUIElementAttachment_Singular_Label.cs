using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public abstract class EditorGUIElementAttachment_Singular_Label : EditorGUIElementAttachment_Singular
    {
        public abstract float GetLabelWidth();

        public EditorGUIElementAttachment_Singular_Label() : base("Label") { }
    }
}