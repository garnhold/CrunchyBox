using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Networking;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    [CustomEditor(typeof(SpriteVectorizer), true)]
    public class SpriteVectorizerEditor : EditorEX_Simple<SpriteVectorizer>
    {
        protected override void InitilizeRootEditorGUIElement(EditorGUIElement_Container_Auto root, SpriteVectorizer item, SerializedObject serialized_object)
        {
            root.AddChild(new EditorGUIElement_Complex_All(serialized_object));
            root.AddChild(new EditorGUIElement_SpriteVectorizerTest(item));
        }
    }
}