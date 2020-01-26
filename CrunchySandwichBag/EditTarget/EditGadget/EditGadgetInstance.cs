using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;    using Sandwich;
    
    public class EditGadgetInstance
    {
        private EditGadget gadget;
        private object gadget_target;

        public EditGadgetInstance(EditGadget g, object t)
        {
            gadget = g;
            gadget_target = t;
        }

        public void Execute(string name)
        {
            gadget.Execute(gadget_target, name);
        }

        public void SetContents(object value)
        {
            gadget.SetContents(gadget_target, value);
        }

        public void SetAuxContents(string name, object value)
        {
            gadget.SetAuxContents(gadget_target, name, value);
        }

        public object GetContents()
        {
            return gadget.GetContents(gadget_target);
        }
        public T GetContents<T>()
        {
            return GetContents().ConvertEX<T>();
        }

        public object GetAuxContents(string name)
        {
            return gadget.GetAuxContents(gadget_target, name);
        }
        public T GetAuxContents<T>(string name)
        {
            return GetAuxContents(name).ConvertEX<T>();
        }

        public EditGadget GetGadget()
        {
            return gadget;
        }

        public EditorSceneElement CreateEditorSceneElement()
        {
            return gadget.GetEditorSceneElementEditGadgetInstanceType()
                .CreateInstance<EditorSceneElement>(this);
        }
    }
}