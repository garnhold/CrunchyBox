using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    public class EditorGUIElementAttachment_Singular_Padding : EditorGUIElementAttachment_Singular
    {
        private float left;
        private float right;
        private float top;
        private float bottom;

        public EditorGUIElementAttachment_Singular_Padding(float l, float r, float t, float b) : base("Padding")
        {
            left = l;
            right = r;
            top = t;
            bottom = b;
        }

        public EditorGUIElementAttachment_Singular_Padding(float lr, float tb) : this(lr, lr, tb, tb) { }
        public EditorGUIElementAttachment_Singular_Padding(float p) : this(p, p) { }

        public override EditorGUIElementPlan PlanContentsInternal(EditorGUIElementPlan plan, EditorGUILayoutState state)
        {
            return plan.Shrink(left, right, bottom, top);
        }
    }
}