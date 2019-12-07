using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Bun;
    using Sandwich;
    
    public class EditorGUIElement_Complex_All : EditorGUIElement_Complex<Tuple<bool, Type>>
    {
        private SerializedObject serialized_object;
        private ReflectedObject reflected_object;

        protected override Tuple<bool, Type> PullState()
        {
            return Tuple.New(serialized_object.HasScript(), serialized_object.GetTargetType());
        }

        protected override EditorGUIElement PushState()
        {
            EditorGUIElement_Container_Auto container = new EditorGUIElement_Container_Auto_Simple_VerticalStrip();

            if (serialized_object.HasScript())
            {
                container.AddChild(new EditorGUIElement_Complex_EditTarget(serialized_object));

                if (reflected_object.IsVisible())
                {
                    container.AddChild(new EditorGUIElement_HorizontalRule());
                    container.AddChild(new EditorGUIElement_Complex_EditTarget(reflected_object));
                }
            }
            else
            {
                container.AddChild(new EditorGUIElement_Complex_MissingScriptSerializedObject(serialized_object));
            }

            return container;
        }

        public EditorGUIElement_Complex_All(SerializedObject s)
        {
            serialized_object = s;
            reflected_object = new ReflectedObject(s.targetObjects);
        }

        public EditorGUIElement_Complex_All(params UnityEngine.Object[] t) : this(new SerializedObject(t)) { }
        public EditorGUIElement_Complex_All(IEnumerable<UnityEngine.Object> t) : this(t.ToArray()) { }
    }
}