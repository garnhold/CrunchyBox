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
    
    public class EditorGUIElementAttachment_SerializedObjectSection : EditorGUIElementAttachment
    {
        private SerializedObject serialized_object;

        public EditorGUIElementAttachment_SerializedObjectSection(SerializedObject s)
        {
            serialized_object = s;
        }

        public override void PreDrawInternal()
        {
            serialized_object.Update();
            EditorGUI.BeginChangeCheck();
        }

        public override void PostDrawInternal()
        {
            if (EditorGUI.EndChangeCheck())
                serialized_object.ApplyModifiedProperties();
        }
    }
}