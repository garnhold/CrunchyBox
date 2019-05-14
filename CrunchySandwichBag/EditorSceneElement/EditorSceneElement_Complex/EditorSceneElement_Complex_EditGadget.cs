using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
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