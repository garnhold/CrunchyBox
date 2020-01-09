using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Networking;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Sandwich;
    
    [CustomEditor(typeof(MonoBehaviour), true)]
    public class DefaultEditor_MonoBehaviour : DefaultEditor<MonoBehaviour> { }

    [CustomEditor(typeof(ScriptableObject), true)]
    public class DefaultEditor_ScriptableObject : DefaultEditor<ScriptableObject> { }

    public abstract class DefaultEditor<T> : EditorEX_Simple<T> where T : UnityEngine.Object
    {
        protected override void InitilizeRootEditorGUIElement(EditorGUIElement_Container_Auto root, EditTarget target)
        {
            root.AddChild(new EditorGUIElement_Complex_EditTarget(target));
        }

        protected override void InitilizeRootEditorSceneElement(EditorSceneElement_Container_Auto root, EditTarget target)
        {
            root.AddChild(new EditorSceneElement_Complex_EditTarget(target));
        }

        public override void OnInspectorGUI()
        {
            if (EditorGUISettings.GetInstance().IsCustomGUIEnabled())
                base.OnInspectorGUI();
            else
                DrawDefaultInspector();
        }

        public override void OnSceneGUI()
        {
            if (EditorGUISettings.GetInstance().IsCustomSceneGUIEnabled())
                base.OnSceneGUI();
        }
    }
}