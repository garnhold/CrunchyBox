using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditorSceneElement_Complex_All : EditorSceneElement_Complex<Type>
    {
        private SerializedObject serialized_object;
        private ReflectedObject reflected_object;

        protected override Type PullState()
        {
            return serialized_object.GetTargetType();
        }

        protected override EditorSceneElement PushState()
        {
            EditorSceneElement_Container_Auto_Simple_Normal container = new EditorSceneElement_Container_Auto_Simple_Normal();

            if (serialized_object.HasScript())
            {
                container.AddChild(new EditorSceneElement_Complex_EditTarget(serialized_object));
                container.AddChild(new EditorSceneElement_Complex_EditTarget(reflected_object));
            }

            return container;
        }

        public EditorSceneElement_Complex_All(SerializedObject s)
        {
            serialized_object = s;
            reflected_object = new ReflectedObject(s.targetObjects);
        }

        public EditorSceneElement_Complex_All(params UnityEngine.Object[] t) : this(new SerializedObject(t)) { }
        public EditorSceneElement_Complex_All(IEnumerable<UnityEngine.Object> t) : this(t.ToArray()) { }
    }
}