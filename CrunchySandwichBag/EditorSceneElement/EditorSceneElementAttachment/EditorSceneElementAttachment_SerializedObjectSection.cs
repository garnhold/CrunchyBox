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
    public class EditorSceneElementAttachment_SerializedObjectSection : EditorSceneElementAttachment
    {
        private SerializedObject serialized_object;

        public EditorSceneElementAttachment_SerializedObjectSection(SerializedObject s)
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