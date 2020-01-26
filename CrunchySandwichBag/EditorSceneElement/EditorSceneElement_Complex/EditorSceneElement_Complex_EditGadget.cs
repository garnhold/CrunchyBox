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
    
    public class EditorSceneElement_Complex_EditGadget : EditorSceneElement_Complex<Type>
    {
        private EditGadget gadget;

        protected override Type PullState()
        {
            return gadget.GetGadgetType();
        }

        protected override EditorSceneElement PushState()
        {
            EditorSceneElement_Container_Auto_Simple_Normal container = new EditorSceneElement_Container_Auto_Simple_Normal();

            container.AddChildren(
                gadget.GetInstances()
                    .Convert(i => i.CreateEditorSceneElement())
            );

            return container;
        }

        public EditorSceneElement_Complex_EditGadget(EditGadget g)
        {
            gadget = g;
        }
    }
}