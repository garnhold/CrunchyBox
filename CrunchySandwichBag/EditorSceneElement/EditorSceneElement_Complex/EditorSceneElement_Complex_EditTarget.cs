using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Salt;
    using Noodle;    using Sandwich;
    
    public class EditorSceneElement_Complex_EditTarget : EditorSceneElement_Complex<Type>
    {
        private EditTarget target;

        protected override Type PullState()
        {
            return target.GetTargetType();
        }

        protected override EditorSceneElement PushState()
        {
            EditorSceneElement_Container_Auto_Simple_Normal container = new EditorSceneElement_Container_Auto_Simple_Normal();

            container.AddChildren(
                target.GetGadgets()
                    .Convert(g => g.CreateEditorSceneElement())
            );

            return container;
        }

        public EditorSceneElement_Complex_EditTarget(EditTarget t)
        {
            target = t;
        }
    }
}